using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using SuperSimpleTcp;
using System.Data.SQLite;

namespace MatchCards_Server
{
    public partial class Server : LostForm
    {
        private SQLiteConnection conn;

        public Server()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=MatchCards.db;Version=3;");
        }

        private SimpleTcpServer server;

        private object matchmakingLock = new object();

        private List<Dictionary<string, string>> usersInUnrankedQueue = new List<Dictionary<string, string>>();
        private List<Dictionary<string, string>> usersInRankedQueue = new List<Dictionary<string, string>>();

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(serverIPText.Text + ":" + serverPortText.Text);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
        }

        private void ClientConnected(object sender, SuperSimpleTcp.ConnectionEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}] client connected.... { Environment.NewLine}";
            userList.Items.Add(e.IpPort);
        }

        private void ClientDisconnected(object sender, SuperSimpleTcp.ConnectionEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}] client disconnected: {e.Reason}{Environment.NewLine}";
            userList.Items.Remove(e.IpPort);
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
            var cmdSyntax = data.Substring(0, 2);

            switch (cmdSyntax)
            {
                case "GP":
                    string userPoints = GetUserPoints(data.Substring(2).Trim());
                    server.Send(e.IpPort, $"[{e.IpPort}]: SP {userPoints}");
                    break;

                case "UQ":
                    MatchmakingLogic(usersInUnrankedQueue, data, e.IpPort, false);
                    break;

                case "RQ":
                    MatchmakingLogic(usersInRankedQueue, data, e.IpPort, true);
                    break;

                case "RO":
                    for (int i = 0; i < userList.Items.Count; i++)
                    {
                        string port = userList.Items[i].ToString();
                        List<string> onlineUsers = GetOnlineUsers();

                        string onlineUsersString = String.Join(", ", onlineUsers);
                        server.Send(port, $"[{e.IpPort}]: !R {onlineUsersString}");
                    }
                    break;

                case "RW":
                    string user = data.Substring(2).Trim();
                    serverLogTextBox.Text += $"[{e.IpPort}]: {user} has been given +50 points {Environment.NewLine}";
                    AddUserPoints(user);
                    break;

                case "RL":
                    string lossingUser = data.Substring(2).Trim();
                    serverLogTextBox.Text += $"[{e.IpPort}]: {lossingUser} has been given -50 points {Environment.NewLine}";
                    RemoveUserPoints(lossingUser);
                    break;

                case "UI":

                    string opponentIpPort = data.Substring(5);
                    string opponentAmountOfPairs = data.Substring(3, 1);
                    server.Send(opponentIpPort.Trim(), $"[{opponentIpPort.Trim()}]: UU {opponentAmountOfPairs}");
                    break;

                case "!!":
                    serverLogTextBox.Text += $"[{e.IpPort}]: {data.Substring(3)}{Environment.NewLine}";
                    break;

                case "UF":
                    string username = data.Substring(2);
                    UpdateLoginStatus(e.IpPort, username, false);
                    break;

                case "--":
                    sendMessageToAllClients(e.IpPort, data);
                    break;

                case "!C":
                    ProcessCreateOrUpdateUser(data, e.IpPort, true);
                    break;

                case "!L":
                    ProcessCreateOrUpdateUser(data, e.IpPort, false);
                    break;

                case "DN":
                    List<string> usernames = GetAllUsernamesFromDB();
                    string joinedUsernames = string.Join(", ", usernames);

                    server.Send(e.IpPort, $"[{e.IpPort}]: UN {joinedUsernames}");
                    break;

                case "GO":
                    string ipPort = data.Substring(3).Trim();
                    server.Send(ipPort, $"[{ipPort}]: EX");
                    break;
            }
        }

        private void MatchmakingLogic(List<Dictionary<string, string>> playerList, string data, string ipPort, bool ranked) 
        {
            Dictionary<string, string> user = new Dictionary<string, string>
            {
                { "client_port", ipPort.ToString() },
                { "usernameInQueue", data.Substring(2) }
            };

            playerList.Add(user);

            int numberOfUsersInQueue = playerList.Count();

            serverLogTextBox.Text += $"Players in {(ranked ? "ranked" : "unranked")} queue: {numberOfUsersInQueue}{Environment.NewLine}";

            sendMessageToAllClients(ipPort, $"-- Players in {(ranked ? "ranked" : "unranked")} queue: {numberOfUsersInQueue}");

            if (numberOfUsersInQueue >= 2)
            {
                List<Dictionary<string, string>> selectedPlayers;

                lock (matchmakingLock) // Lock the block to ensure synchronization
                {
                    if (numberOfUsersInQueue >= 2)
                    {
                        selectedPlayers = getRandomPlayersFromQueue(playerList);

                        PlayerMatchmaking(server, selectedPlayers[0], selectedPlayers[1], ranked);

                        playerList.Remove(selectedPlayers[0]);
                        playerList.Remove(selectedPlayers[1]);
                    }
                }
            }
        }

        private async void PlayerMatchmaking(SimpleTcpServer server, Dictionary<string, string> user1, Dictionary<string, string> user2, bool ranked)
        {
            string clientPort1 = user1["client_port"];
            string usernameInQueue1 = user1["usernameInQueue"];

            string clientPort2 = user2["client_port"];
            string usernameInQueue2 = user2["usernameInQueue"];

            await Task.Delay(1000);
            server.Send(clientPort1, $"[{clientPort1}]: {(ranked ? "RG" : "UG")} [{usernameInQueue2.Trim().Length}] {usernameInQueue2} {clientPort2}");
            server.Send(clientPort2, $"[{clientPort2}]: {(ranked ? "RG" : "UG")} [{usernameInQueue1.Trim().Length}] {usernameInQueue1} {clientPort1}");
        }


        private void sendMessageToAllClients(string ipPort, string data) 
        {
            for (int i = 0; i < userList.Items.Count; i++)
            {
                string port = userList.Items[i].ToString();
                server.Send(port, $"[{ipPort}] {data.Substring(2)}");
            }
        }

        private List<Dictionary<string, string>> getRandomPlayersFromQueue(List<Dictionary<string, string>> list)
        {
            List<Dictionary<string, string>> twoGamePlayers = new List<Dictionary<string, string>>();

            Random randomPick = new Random();

            // Select two random players
            for (int i = 0; i < 2; i++)
            {
                // Generate a random index within the range of the list
                int randomIndex = randomPick.Next(0, list.Count);

                // Get the randomly selected player from the list
                Dictionary<string, string> selectedPlayer = list[randomIndex];

                // Add the selected player to the twoGamePlayers list
                twoGamePlayers.Add(selectedPlayer);

                // Remove the selected player from the userInUnrankedQueue list
                list.RemoveAt(randomIndex);
            }

            return twoGamePlayers;
        }


        private void ProcessCreateOrUpdateUser(string data, string ipPort, bool isCreate)
        {
            int userLength = int.Parse(data.Substring(4, 1));
            string username = data.Substring(7, userLength);
            string password = data.Substring(7 + userLength + 3);

            if (isCreate)
            {
                CreateNewUser(username, password);
            }
            else
            {
                CheckLoginInformation(ipPort, username, password);
            }
        }

        private List<string> GetAllUsernamesFromDB()
        {
            conn.Open();
            string sql = "SELECT Username FROM Users";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            List<string> usernames = new List<string>();

            while (reader.Read())
            {
                string username = reader.GetString(0);
                usernames.Add(username);
            }

            conn.Close();

            return usernames;
        }


        private void RemoveUserPoints(string username)
        {
            string currentUserPoints = GetUserPoints(username);
            int newUserPoints = 0;

            if (int.Parse(currentUserPoints) == 0) 
            {
                newUserPoints = 0;
            }
            else
            {
                newUserPoints = int.Parse(currentUserPoints) - 50;
            }

            conn.Open();
            string sql = "UPDATE Users SET Points = @NewPoints WHERE Username = @Username";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@NewPoints", newUserPoints);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void AddUserPoints(string username) 
        {
            string currentUserPoints = GetUserPoints(username);
            int newUserPoints = int.Parse(currentUserPoints) + 50;

            conn.Open();
            string sql = "UPDATE Users SET Points = @NewPoints WHERE Username = @Username";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@NewPoints", newUserPoints);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private string GetUserPoints(string username)
        {
            string points = null;
            conn.Open();
            string sql = "SELECT Points FROM Users WHERE Username = @Username";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    points = reader["Points"].ToString();
                }
            }

            conn.Close();
            return points;
        }


        private void CreateNewUser(string username, string password)
        {
            conn.Open();
            string sql = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            conn.Close();

            serverLogTextBox.Text += $"A new user {username} created{Environment.NewLine}";
        }

        private List<string> GetOnlineUsers() 
        {
            conn.Open();
            string sql = "SELECT Username FROM Users WHERE Online = 1";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<string> onlineUsers = new List<string>();
            while (reader.Read())
            {
                onlineUsers.Add(reader.GetString(0));
            }

            conn.Close();

            return onlineUsers;
        }

        private async void UpdateLoginStatus(string ipPort, string username, bool status) 
        {
            if (status == true)
            {
                conn.Open();
                string sql = "UPDATE Users SET Online = 1 WHERE Username = @Username";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
                conn.Close();

                await Task.Delay(1000); // Wait for 1 second asynchronously
                
                for (int i = 0; i < userList.Items.Count; i++)
                {
                    string port = userList.Items[i].ToString();
                    List<string> onlineUsers = GetOnlineUsers();

                    string onlineUsersString = String.Join(", ", onlineUsers);
                    server.Send(port, $"[{ipPort}]: !O {onlineUsersString}");
          
                }
            }
            else 
            {
                conn.Open();
                string sql = "UPDATE Users SET Online = 0 WHERE Username = @Username";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username.Trim());
                cmd.ExecuteNonQuery();
                conn.Close();

                await Task.Delay(1000); // Wait for 1 second asynchronously

                for (int i = 0; i < userList.Items.Count; i++)
                {
                    string port = userList.Items[i].ToString();
                    List<string> onlineUsers = GetOnlineUsers();

                    string onlineUsersString = String.Join(", ", onlineUsers);
                    server.Send(port, $"[{ipPort}]: !F {onlineUsersString}");
                }
            }
        }
        private string CheckIfUserAlreadyIsOnline(string username)
        {
            string online = null;
            conn.Open();
            string sql = "SELECT Online FROM Users WHERE Username = @Username";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    online = reader["Online"].ToString();
                }
            }

            conn.Close();
            return online;
        }

        private void CheckLoginInformation(string ipPort, string username, string password)
        {
            conn.Open();
            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            if (count > 0)
            {
                server.Send(ipPort, $"[{username.Count()}] : {username} : VALID : {CheckIfUserAlreadyIsOnline(username)}");
                UpdateLoginStatus(ipPort, username, true);
            }
            else
            {
                server.Send(ipPort, $"[{username.Count()}] : {username} : INVALID");
            }
        }

        private void ServerLabel_Click(object sender, EventArgs e)
        {

        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            server.Start();
            serverLogTextBox.Text += $"Starting.... {Environment.NewLine}";
            startServerButton.Enabled = false;
            stopServerButton.Enabled = true;
        }

        private void serverLogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopServerButton_Click(object sender, EventArgs e)
        {
            server.Stop();
            stopServerButton.Enabled = false;
            startServerButton.Enabled = true;
            serverLogTextBox.Text += $"All Players have been set to offline....{Environment.NewLine}";
            serverLogTextBox.Text += $"Stopping....{Environment.NewLine}";
            setAllPlayersOffline();
        }

        private void setAllPlayersOffline()
        {
            conn.Open();
            string sql = "UPDATE Users SET Online = 0";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(serverChatBox.Text) && userList.SelectedItem != null) 
                {
                    server.Send(userList.SelectedItem.ToString(), $"[{userList.SelectedItem.ToString()}]: [Server]: {serverChatBox.Text}");
                    serverLogTextBox.Text += $"Server: {serverChatBox.Text}{Environment.NewLine}";
                    serverChatBox.Text = string.Empty;
                }
            }
        }

        private void serverChatBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            setAllPlayersOffline();
        }
    }
}
