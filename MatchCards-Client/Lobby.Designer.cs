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
            this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel8 = new ReaLTaiizor.Controls.CrownLabel();
            this.crownLabel7 = new ReaLTaiizor.Controls.CrownLabel();
            this.lostLabel4 = new ReaLTaiizor.Controls.LostLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lostAcceptButton2 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostAcceptButton1 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.crownLabel9 = new ReaLTaiizor.Controls.CrownLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crownLabel10 = new ReaLTaiizor.Controls.CrownLabel();
            this.lostLabel1 = new ReaLTaiizor.Controls.LostLabel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatLabel
            // 
            this.chatLabel.AutoSize = true;
            this.chatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.chatLabel.Location = new System.Drawing.Point(3, 0);
            this.chatLabel.Name = "chatLabel";
            this.chatLabel.Size = new System.Drawing.Size(60, 28);
            this.chatLabel.TabIndex = 0;
            this.chatLabel.Text = "CHAT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendMessage);
            this.panel1.Controls.Add(this.lobbyTextBox);
            this.panel1.Controls.Add(this.clientChatBox);
            this.panel1.Controls.Add(this.chatLabel);
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 237);
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
            this.sendMessage.Location = new System.Drawing.Point(332, 201);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(50, 34);
            this.sendMessage.TabIndex = 3;
            this.sendMessage.Text = "SEND";
            this.sendMessage.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // lobbyTextBox
            // 
            this.lobbyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.lobbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lobbyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lobbyTextBox.Location = new System.Drawing.Point(7, 201);
            this.lobbyTextBox.Name = "lobbyTextBox";
            this.lobbyTextBox.Size = new System.Drawing.Size(319, 34);
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
            this.clientChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.clientChatBox.Size = new System.Drawing.Size(375, 171);
            this.clientChatBox.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.crownLabel2);
            this.panel5.Controls.Add(this.crownLabel1);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Controls.Add(this.lostLabel4);
            this.panel5.Location = new System.Drawing.Point(402, 96);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 180);
            this.panel5.TabIndex = 18;
            // 
            // crownLabel2
            // 
            this.crownLabel2.AutoSize = true;
            this.crownLabel2.ForeColor = System.Drawing.Color.White;
            this.crownLabel2.Location = new System.Drawing.Point(93, 35);
            this.crownLabel2.Name = "crownLabel2";
            this.crownLabel2.Size = new System.Drawing.Size(79, 28);
            this.crownLabel2.TabIndex = 18;
            this.crownLabel2.Text = "POINTS";
            // 
            // crownLabel1
            // 
            this.crownLabel1.AutoSize = true;
            this.crownLabel1.ForeColor = System.Drawing.Color.White;
            this.crownLabel1.Location = new System.Drawing.Point(6, 35);
            this.crownLabel1.Name = "crownLabel1";
            this.crownLabel1.Size = new System.Drawing.Size(68, 28);
            this.crownLabel1.TabIndex = 17;
            this.crownLabel1.Text = "NAME";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.50954F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Controls.Add(this.crownLabel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.crownLabel7, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 87);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // crownLabel4
            // 
            this.crownLabel4.AutoSize = true;
            this.crownLabel4.ForeColor = System.Drawing.Color.White;
            this.crownLabel4.Location = new System.Drawing.Point(90, 0);
            this.crownLabel4.Name = "crownLabel4";
            this.crownLabel4.Size = new System.Drawing.Size(56, 25);
            this.crownLabel4.TabIndex = 19;
            this.crownLabel4.Text = "2000";
            // 
            // crownLabel3
            // 
            this.crownLabel3.AutoSize = true;
            this.crownLabel3.ForeColor = System.Drawing.Color.White;
            this.crownLabel3.Location = new System.Drawing.Point(3, 0);
            this.crownLabel3.Name = "crownLabel3";
            this.crownLabel3.Size = new System.Drawing.Size(76, 25);
            this.crownLabel3.TabIndex = 18;
            this.crownLabel3.Text = "Player1";
            // 
            // crownLabel6
            // 
            this.crownLabel6.AutoSize = true;
            this.crownLabel6.ForeColor = System.Drawing.Color.White;
            this.crownLabel6.Location = new System.Drawing.Point(90, 25);
            this.crownLabel6.Name = "crownLabel6";
            this.crownLabel6.Size = new System.Drawing.Size(56, 24);
            this.crownLabel6.TabIndex = 21;
            this.crownLabel6.Text = "1950";
            // 
            // crownLabel5
            // 
            this.crownLabel5.AutoSize = true;
            this.crownLabel5.ForeColor = System.Drawing.Color.White;
            this.crownLabel5.Location = new System.Drawing.Point(3, 25);
            this.crownLabel5.Name = "crownLabel5";
            this.crownLabel5.Size = new System.Drawing.Size(76, 24);
            this.crownLabel5.TabIndex = 20;
            this.crownLabel5.Text = "Player2";
            // 
            // crownLabel8
            // 
            this.crownLabel8.AutoSize = true;
            this.crownLabel8.ForeColor = System.Drawing.Color.White;
            this.crownLabel8.Location = new System.Drawing.Point(90, 49);
            this.crownLabel8.Name = "crownLabel8";
            this.crownLabel8.Size = new System.Drawing.Size(45, 28);
            this.crownLabel8.TabIndex = 23;
            this.crownLabel8.Text = "500";
            // 
            // crownLabel7
            // 
            this.crownLabel7.AutoSize = true;
            this.crownLabel7.ForeColor = System.Drawing.Color.White;
            this.crownLabel7.Location = new System.Drawing.Point(3, 49);
            this.crownLabel7.Name = "crownLabel7";
            this.crownLabel7.Size = new System.Drawing.Size(76, 28);
            this.crownLabel7.TabIndex = 22;
            this.crownLabel7.Text = "Player3";
            // 
            // lostLabel4
            // 
            this.lostLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel4.ForeColor = System.Drawing.Color.White;
            this.lostLabel4.Location = new System.Drawing.Point(3, 5);
            this.lostLabel4.Name = "lostLabel4";
            this.lostLabel4.Size = new System.Drawing.Size(221, 27);
            this.lostLabel4.TabIndex = 15;
            this.lostLabel4.Text = "ONLINE PLAYERS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 303);
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
            this.crownLabel9.Location = new System.Drawing.Point(4, 279);
            this.crownLabel9.Name = "crownLabel9";
            this.crownLabel9.Size = new System.Drawing.Size(98, 28);
            this.crownLabel9.TabIndex = 20;
            this.crownLabel9.Text = "MATCHES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crownLabel10);
            this.panel2.Controls.Add(this.lostLabel1);
            this.panel2.Location = new System.Drawing.Point(402, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 51);
            this.panel2.TabIndex = 19;
            // 
            // crownLabel10
            // 
            this.crownLabel10.AutoSize = true;
            this.crownLabel10.ForeColor = System.Drawing.Color.White;
            this.crownLabel10.Location = new System.Drawing.Point(178, 3);
            this.crownLabel10.Name = "crownLabel10";
            this.crownLabel10.Size = new System.Drawing.Size(56, 28);
            this.crownLabel10.TabIndex = 20;
            this.crownLabel10.Text = "2000";
            // 
            // lostLabel1
            // 
            this.lostLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel1.ForeColor = System.Drawing.Color.White;
            this.lostLabel1.Location = new System.Drawing.Point(3, 3);
            this.lostLabel1.Name = "lostLabel1";
            this.lostLabel1.Size = new System.Drawing.Size(146, 45);
            this.lostLabel1.TabIndex = 15;
            this.lostLabel1.Text = "YOUR POINTS";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 459);
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
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.LostLabel lostLabel4;
        private ReaLTaiizor.Controls.CrownLabel crownLabel2;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel4;
        private ReaLTaiizor.Controls.CrownLabel crownLabel3;
        private ReaLTaiizor.Controls.CrownLabel crownLabel6;
        private ReaLTaiizor.Controls.CrownLabel crownLabel5;
        private ReaLTaiizor.Controls.CrownLabel crownLabel8;
        private ReaLTaiizor.Controls.CrownLabel crownLabel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton2;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel9;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.LostLabel lostLabel1;
        private ReaLTaiizor.Controls.CrownLabel crownLabel10;
    }
}

