using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using SuperSimpleTcp;

namespace MatchCards_Client
{
    public partial class Game : LostForm
    {
        public Game()
        {
            InitializeComponent();
        }

        private string[] PossibleCardValues = { "A", "A", "B", "B", "C", "C", "D", "D", "E", "E", "F", "F", "G", "G", "H", "H" };
        private Label[] CardLabels = new Label[16];
        private Label firstCard = null;
        private Label secondCard = null;
        private string[] FinalCardValues;
        private int amountOfMousePresses = 0;
        private int amountOfPairs = 0;

        private void ShuffleArray<T>(T[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        private void InitializeCards()
        {
            FinalCardValues = new string[PossibleCardValues.Length];
            PossibleCardValues.CopyTo(FinalCardValues, 0);
            ShuffleArray(FinalCardValues);

            for (int i = 0; i < CardLabels.Length; i++)
            {
                CardLabels[i].Text = "?";
                CardLabels[i].Enabled = true;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            TcpClientSingleton.Client.Events.DataReceived += DataReceived;

            localClientName.Text = $"{User.Username}";
            onlinePlayerName.Text = $"{User.OpponentUserName}";
            User.OpponentPairs = "0";

            CardLabels = new Label[]
            {
                cardStatus0, cardStatus1, cardStatus2, cardStatus3,
                cardStatus4, cardStatus5, cardStatus6, cardStatus7,
                cardStatus8, cardStatus9, cardStatus10, cardStatus11,
                cardStatus12, cardStatus13, cardStatus14, cardStatus15
            };

            InitializeCards();

            foreach (var cardLabel in CardLabels)
            {
                cardLabel.Click += cardStatus_Click;
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = $"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count).Substring(e.IpPort.Length + 5)}";
            string cmdSyntax = data.Substring(0, 2);

            switch (cmdSyntax) 
            {
                case "UU":
                    User.OpponentPairs = data.Substring(3);
                    break;
                case "EX":
                    LobbyChange();
                    break;
            }
        }

        private async void cardStatus_Click(object sender, EventArgs e)
        {
            if (amountOfMousePresses == 2)
            {
                return;
            }

            Label clickedCard = (Label)sender;
            int cardIndex = Array.IndexOf(CardLabels, clickedCard);

            if (clickedCard.Text == "?")
            {
                clickedCard.Text = FinalCardValues[cardIndex];
                amountOfMousePresses++;

                if (amountOfMousePresses == 1)
                {
                    firstCard = clickedCard;
                }
                else if (amountOfMousePresses == 2)
                {
                    secondCard = clickedCard;
                    CheckCardMatch();
                }
            }

            TcpClientSingleton.Client.Send($"UI {amountOfPairs} {User.OpponentIpPort}");

            localNoOfPairs.Text = amountOfPairs.ToString();
            noOfPairsOnline.Text = User.OpponentPairs;

            if (amountOfPairs == 8 && User.TypeOfGame == "Ranked")
            {
                TcpClientSingleton.Client.Send($"RW {User.Username}");
                await Task.Delay(100);
                TcpClientSingleton.Client.Send($"RL {User.OpponentUserName}");
                await Task.Delay(100);
                GameOver();
            }
            else if (amountOfPairs == 8 && User.TypeOfGame == "Unranked") 
            {
                GameOver();  
            }

        }

        private async void GameOver() 
        {
            LobbyChange();
            await Task.Delay(100);
            TcpClientSingleton.Client.Send($"GO {User.OpponentIpPort}");
            await Task.Delay(100);
            TcpClientSingleton.Client.Send($"-- {(User.TypeOfGame == "Ranked" ? "[Ranked]" : "[Unranked]")} {User.Username} won against {User.OpponentUserName}");
            User.OpponentIpPort = "";
            User.OpponentUserName = "";
            User.OpponentPairs = "";
            User.TypeOfGame = "";
        }

        private void LobbyChange()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LobbyChange));
                return;
            }

            TcpClientSingleton.Client.Events.DataReceived -= DataReceived;

            var lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }

        private void CheckCardMatch()
        {
            if (firstCard.Text == secondCard.Text)
            {
                // Cards match, disable clicks on matched cards
                firstCard.Enabled = false;
                secondCard.Enabled = false;
      
                // Reset variables for the next pair
                firstCard = null;
                secondCard = null;
                amountOfMousePresses = 0;
                amountOfPairs++;
            }
            else
            {
                // Cards don't match, delay before flipping them back
                Timer flipTimer = new Timer();
                flipTimer.Interval = 1000; // 1 second delay
                flipTimer.Tick += FlipTimer_Tick;

                flipTimer.Start();
            }
        }

        private void FlipTimer_Tick(object sender, EventArgs e)
        {
            Timer flipTimer = (Timer)sender;

            // Flip the unmatched cards back to "?"
            firstCard.Text = "?";
            secondCard.Text = "?";
            firstCard.Enabled = true;
            secondCard.Enabled = true;

            // Reset variables for the next pair
            firstCard = null;
            secondCard = null;
            amountOfMousePresses = 0;

            flipTimer.Stop();
            flipTimer.Dispose();
        }

        private void card1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crownLabel17_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
