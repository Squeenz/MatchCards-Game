namespace MatchCards_Client
{
    partial class Lobby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.chatLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sendMessage = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lobbyTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.clientChatBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.onlineUserList = new System.Windows.Forms.ListBox();
            this.lostLabel4 = new ReaLTaiizor.Controls.LostLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lostAcceptButton2 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostAcceptButton1 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.crownLabel9 = new ReaLTaiizor.Controls.CrownLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pointsLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.lostLabel1 = new ReaLTaiizor.Controls.LostLabel();
            this.welcomeLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernameLabel = new ReaLTaiizor.Controls.CrownLabel();
            this.help = new ReaLTaiizor.Controls.LostLabel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.chatLabel.Location = new System.Drawing.Point(3, 0);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(48, 21);
            this.chatLabel.TabIndex = 0;
            this.chatLabel.Text = "CHAT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendMessage);
            this.panel1.Controls.Add(this.lobbyTextBox);
            this.panel1.Controls.Add(this.clientChatBox);
            this.panel1.Controls.Add(this.chatLabel);
            this.panel1.Location = new System.Drawing.Point(8, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 267);
            this.panel1.TabIndex = 1;
            // 
            // sendMessage
            // 
            this.sendMessage.BackColor = System.Drawing.Color.SeaGreen;
            this.sendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendMessage.ForeColor = System.Drawing.Color.White;
            this.sendMessage.HoverColor = System.Drawing.Color.Green;
            this.sendMessage.Image = null;
            this.sendMessage.Location = new System.Drawing.Point(332, 224);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(50, 29);
            this.sendMessage.TabIndex = 3;
            this.sendMessage.Text = "SEND";
            this.sendMessage.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // lobbyTextBox
            // 
            this.lobbyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lobbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lobbyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lobbyTextBox.Location = new System.Drawing.Point(7, 224);
            this.lobbyTextBox.Name = "lobbyTextBox";
            this.lobbyTextBox.Size = new System.Drawing.Size(319, 29);
            this.lobbyTextBox.TabIndex = 2;
            // 
            // clientChatBox
            // 
            this.clientChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.clientChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientChatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.clientChatBox.Location = new System.Drawing.Point(7, 24);
            this.clientChatBox.Multiline = true;
            this.clientChatBox.Name = "clientChatBox";
            this.clientChatBox.ReadOnly = true;
            this.clientChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clientChatBox.Size = new System.Drawing.Size(375, 194);
            this.clientChatBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.onlineUserList);
            this.panel5.Controls.Add(this.lostLabel4);
            this.panel5.Location = new System.Drawing.Point(405, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 202);
            this.panel5.TabIndex = 18;
            // 
            // onlineUserList
            // 
            this.onlineUserList.FormattingEnabled = true;
            this.onlineUserList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.onlineUserList.ItemHeight = 21;
            this.onlineUserList.Location = new System.Drawing.Point(10, 37);
            this.onlineUserList.Name = "onlineUserList";
            this.onlineUserList.Size = new System.Drawing.Size(205, 151);
            this.onlineUserList.TabIndex = 19;
            // 
            // lostLabel4
            // 
            this.lostLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel4.ForeColor = System.Drawing.Color.White;
            this.lostLabel4.Location = new System.Drawing.Point(10, 6);
            this.lostLabel4.Name = "lostLabel4";
            this.lostLabel4.Size = new System.Drawing.Size(129, 25);
            this.lostLabel4.TabIndex = 15;
            this.lostLabel4.Text = "ONLINE PLAYERS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 330);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(624, 147);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // lostAcceptButton2
            // 
            this.lostAcceptButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.lostAcceptButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostAcceptButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostAcceptButton2.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton2.HoverColor = System.Drawing.Color.Green;
            this.lostAcceptButton2.Image = null;
            this.lostAcceptButton2.Location = new System.Drawing.Point(3, 77);
            this.lostAcceptButton2.Name = "lostAcceptButton2";
            this.lostAcceptButton2.Size = new System.Drawing.Size(618, 67);
            this.lostAcceptButton2.TabIndex = 5;
            this.lostAcceptButton2.Text = "UNRANKED";
            this.lostAcceptButton2.Click += new System.EventHandler(this.lostAcceptButton2_Click);
            // 
            // lostAcceptButton1
            // 
            this.lostAcceptButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.lostAcceptButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostAcceptButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostAcceptButton1.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton1.HoverColor = System.Drawing.Color.Green;
            this.lostAcceptButton1.Image = null;
            this.lostAcceptButton1.Location = new System.Drawing.Point(3, 3);
            this.lostAcceptButton1.Name = "lostAcceptButton1";
            this.lostAcceptButton1.Size = new System.Drawing.Size(618, 66);
            this.lostAcceptButton1.TabIndex = 4;
            this.lostAcceptButton1.Text = "RANKED";
            this.lostAcceptButton1.Click += new System.EventHandler(this.lostAcceptButton1_Click);
            // 
            // crownLabel9
            // 
            this.crownLabel9.AutoSize = true;
            this.crownLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownLabel9.Location = new System.Drawing.Point(7, 306);
            this.crownLabel9.Name = "crownLabel9";
            this.crownLabel9.Size = new System.Drawing.Size(78, 21);
            this.crownLabel9.TabIndex = 20;
            this.crownLabel9.Text = "MATCHES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pointsLabel);
            this.panel2.Controls.Add(this.lostLabel1);
            this.panel2.Location = new System.Drawing.Point(405, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 29);
            this.panel2.TabIndex = 19;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.ForeColor = System.Drawing.Color.Lime;
            this.pointsLabel.Location = new System.Drawing.Point(114, 5);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(19, 21);
            this.pointsLabel.TabIndex = 20;
            this.pointsLabel.Text = "0";
            // 
            // lostLabel1
            // 
            this.lostLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel1.ForeColor = System.Drawing.Color.White;
            this.lostLabel1.Location = new System.Drawing.Point(7, 5);
            this.lostLabel1.Name = "lostLabel1";
            this.lostLabel1.Size = new System.Drawing.Size(107, 21);
            this.lostLabel1.TabIndex = 15;
            this.lostLabel1.Text = "YOUR POINTS:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.welcomeLabel.Location = new System.Drawing.Point(3, 3);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(87, 21);
            this.welcomeLabel.TabIndex = 21;
            this.welcomeLabel.Text = "WELCOME,";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usernameLabel);
            this.panel3.Controls.Add(this.welcomeLabel);
            this.panel3.Location = new System.Drawing.Point(405, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 27);
            this.panel3.TabIndex = 22;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.usernameLabel.Location = new System.Drawing.Point(84, 3);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 21);
            this.usernameLabel.TabIndex = 22;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.help.ForeColor = System.Drawing.Color.White;
            this.help.Location = new System.Drawing.Point(534, 5);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(44, 23);
            this.help.TabIndex = 23;
            this.help.Text = "HELP";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 503);
            this.Controls.Add(this.help);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crownLabel9);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
            this.MaximizeBox = false;
            this.Name = "Lobby";
            this.Sizable = false;
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownLabel chatLabel;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.CrownTextBox lobbyTextBox;
        private ReaLTaiizor.Controls.CrownTextBox clientChatBox;
        private ReaLTaiizor.Controls.LostAcceptButton sendMessage;
        private System.Windows.Forms.Panel panel5;
        private ReaLTaiizor.Controls.LostLabel lostLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton2;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel9;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.LostLabel lostLabel1;
        private ReaLTaiizor.Controls.CrownLabel pointsLabel;
        private System.Windows.Forms.ListBox onlineUserList;
        private ReaLTaiizor.Controls.CrownLabel welcomeLabel;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.CrownLabel usernameLabel;
        private ReaLTaiizor.Controls.LostLabel help;
    }
}

