namespace MatchCards_Server
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.startServerButton = new ReaLTaiizor.Controls.LostAcceptButton();
            this.serverLabel = new ReaLTaiizor.Controls.LostLabel();
            this.serverIPText = new ReaLTaiizor.Controls.CrownTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.serverPortText = new ReaLTaiizor.Controls.CrownTextBox();
            this.lostLabel1 = new ReaLTaiizor.Controls.LostLabel();
            this.stopServerButton = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostLabel2 = new ReaLTaiizor.Controls.LostLabel();
            this.serverLogTextBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lostLabel3 = new ReaLTaiizor.Controls.LostLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lostAcceptButton15 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostAcceptButton14 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostAcceptButton12 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostAcceptButton13 = new ReaLTaiizor.Controls.LostAcceptButton();
            this.lostLabel4 = new ReaLTaiizor.Controls.LostLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.userList = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sendServerMessage = new ReaLTaiizor.Controls.LostAcceptButton();
            this.serverChatBox = new ReaLTaiizor.Controls.CrownTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // startServerButton
            // 
            this.startServerButton.BackColor = System.Drawing.Color.SeaGreen;
            this.startServerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startServerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startServerButton.ForeColor = System.Drawing.Color.White;
            this.startServerButton.HoverColor = System.Drawing.Color.Green;
            this.startServerButton.Image = null;
            this.startServerButton.Location = new System.Drawing.Point(215, 3);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(119, 32);
            this.startServerButton.TabIndex = 2;
            this.startServerButton.Text = "START";
            this.startServerButton.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // serverLabel
            // 
            this.serverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.serverLabel.ForeColor = System.Drawing.Color.White;
            this.serverLabel.Location = new System.Drawing.Point(3, 3);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(70, 27);
            this.serverLabel.TabIndex = 1;
            this.serverLabel.Text = "IP";
            this.serverLabel.Click += new System.EventHandler(this.ServerLabel_Click);
            // 
            // serverIPText
            // 
            this.serverIPText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.serverIPText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverIPText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.serverIPText.Location = new System.Drawing.Point(79, 1);
            this.serverIPText.Name = "serverIPText";
            this.serverIPText.Size = new System.Drawing.Size(121, 29);
            this.serverIPText.TabIndex = 2;
            this.serverIPText.Text = "127.0.0.1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.serverIPText);
            this.panel1.Controls.Add(this.serverLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.serverPortText);
            this.panel2.Controls.Add(this.lostLabel1);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 4;
            // 
            // serverPortText
            // 
            this.serverPortText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.serverPortText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverPortText.Enabled = false;
            this.serverPortText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.serverPortText.Location = new System.Drawing.Point(79, 1);
            this.serverPortText.Name = "serverPortText";
            this.serverPortText.Size = new System.Drawing.Size(121, 29);
            this.serverPortText.TabIndex = 2;
            this.serverPortText.Text = "8910";
            // 
            // lostLabel1
            // 
            this.lostLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel1.ForeColor = System.Drawing.Color.White;
            this.lostLabel1.Location = new System.Drawing.Point(3, 3);
            this.lostLabel1.Name = "lostLabel1";
            this.lostLabel1.Size = new System.Drawing.Size(70, 27);
            this.lostLabel1.TabIndex = 1;
            this.lostLabel1.Text = "PORT";
            // 
            // stopServerButton
            // 
            this.stopServerButton.BackColor = System.Drawing.Color.Crimson;
            this.stopServerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopServerButton.Enabled = false;
            this.stopServerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopServerButton.ForeColor = System.Drawing.Color.White;
            this.stopServerButton.HoverColor = System.Drawing.Color.Maroon;
            this.stopServerButton.Image = null;
            this.stopServerButton.Location = new System.Drawing.Point(215, 39);
            this.stopServerButton.Name = "stopServerButton";
            this.stopServerButton.Size = new System.Drawing.Size(119, 32);
            this.stopServerButton.TabIndex = 5;
            this.stopServerButton.Text = "STOP";
            this.stopServerButton.Click += new System.EventHandler(this.stopServerButton_Click);
            // 
            // lostLabel2
            // 
            this.lostLabel2.BackColor = System.Drawing.Color.Crimson;
            this.lostLabel2.ForeColor = System.Drawing.Color.White;
            this.lostLabel2.Location = new System.Drawing.Point(3, 84);
            this.lostLabel2.Name = "lostLabel2";
            this.lostLabel2.Size = new System.Drawing.Size(338, 27);
            this.lostLabel2.TabIndex = 6;
            this.lostLabel2.Text = "Server Log";
            // 
            // serverLogTextBox
            // 
            this.serverLogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.serverLogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverLogTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.serverLogTextBox.Location = new System.Drawing.Point(3, 117);
            this.serverLogTextBox.Multiline = true;
            this.serverLogTextBox.Name = "serverLogTextBox";
            this.serverLogTextBox.ReadOnly = true;
            this.serverLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serverLogTextBox.Size = new System.Drawing.Size(338, 271);
            this.serverLogTextBox.TabIndex = 12;
            this.serverLogTextBox.TextChanged += new System.EventHandler(this.serverLogTextBox_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.69231F));
            this.tableLayoutPanel1.Controls.Add(this.lostLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.serverLogTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 395);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.startServerButton);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.stopServerButton);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 72);
            this.panel3.TabIndex = 0;
            // 
            // lostLabel3
            // 
            this.lostLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel3.ForeColor = System.Drawing.Color.White;
            this.lostLabel3.Location = new System.Drawing.Point(3, 3);
            this.lostLabel3.Name = "lostLabel3";
            this.lostLabel3.Size = new System.Drawing.Size(92, 27);
            this.lostLabel3.TabIndex = 15;
            this.lostLabel3.Text = "ACTIONS";
            this.lostLabel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Controls.Add(this.lostLabel3);
            this.panel4.Location = new System.Drawing.Point(357, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 198);
            this.panel4.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton15, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lostAcceptButton13, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.87234F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.12766F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 92);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // lostAcceptButton15
            // 
            this.lostAcceptButton15.BackColor = System.Drawing.Color.Crimson;
            this.lostAcceptButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostAcceptButton15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostAcceptButton15.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton15.HoverColor = System.Drawing.Color.Maroon;
            this.lostAcceptButton15.Image = null;
            this.lostAcceptButton15.Location = new System.Drawing.Point(3, 47);
            this.lostAcceptButton15.Name = "lostAcceptButton15";
            this.lostAcceptButton15.Size = new System.Drawing.Size(145, 40);
            this.lostAcceptButton15.TabIndex = 9;
            this.lostAcceptButton15.Text = "WARN";
            this.lostAcceptButton15.Visible = false;
            // 
            // lostAcceptButton14
            // 
            this.lostAcceptButton14.BackColor = System.Drawing.Color.Crimson;
            this.lostAcceptButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostAcceptButton14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostAcceptButton14.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton14.HoverColor = System.Drawing.Color.Maroon;
            this.lostAcceptButton14.Image = null;
            this.lostAcceptButton14.Location = new System.Drawing.Point(154, 47);
            this.lostAcceptButton14.Name = "lostAcceptButton14";
            this.lostAcceptButton14.Size = new System.Drawing.Size(145, 40);
            this.lostAcceptButton14.TabIndex = 8;
            this.lostAcceptButton14.Text = "RESET";
            this.lostAcceptButton14.Visible = false;
            // 
            // lostAcceptButton12
            // 
            this.lostAcceptButton12.BackColor = System.Drawing.Color.Crimson;
            this.lostAcceptButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostAcceptButton12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostAcceptButton12.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton12.HoverColor = System.Drawing.Color.Maroon;
            this.lostAcceptButton12.Image = null;
            this.lostAcceptButton12.Location = new System.Drawing.Point(3, 3);
            this.lostAcceptButton12.Name = "lostAcceptButton12";
            this.lostAcceptButton12.Size = new System.Drawing.Size(145, 38);
            this.lostAcceptButton12.TabIndex = 6;
            this.lostAcceptButton12.Text = "KICK";
            this.lostAcceptButton12.Visible = false;
            // 
            // lostAcceptButton13
            // 
            this.lostAcceptButton13.BackColor = System.Drawing.Color.Crimson;
            this.lostAcceptButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostAcceptButton13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostAcceptButton13.ForeColor = System.Drawing.Color.White;
            this.lostAcceptButton13.HoverColor = System.Drawing.Color.Maroon;
            this.lostAcceptButton13.Image = null;
            this.lostAcceptButton13.Location = new System.Drawing.Point(154, 3);
            this.lostAcceptButton13.Name = "lostAcceptButton13";
            this.lostAcceptButton13.Size = new System.Drawing.Size(145, 38);
            this.lostAcceptButton13.TabIndex = 7;
            this.lostAcceptButton13.Text = "BAN";
            this.lostAcceptButton13.Visible = false;
            // 
            // lostLabel4
            // 
            this.lostLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostLabel4.ForeColor = System.Drawing.Color.White;
            this.lostLabel4.Location = new System.Drawing.Point(3, 3);
            this.lostLabel4.Name = "lostLabel4";
            this.lostLabel4.Size = new System.Drawing.Size(70, 27);
            this.lostLabel4.TabIndex = 15;
            this.lostLabel4.Text = "PLAYERS";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.userList);
            this.panel6.Location = new System.Drawing.Point(3, 36);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(302, 212);
            this.panel6.TabIndex = 20;
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 21;
            this.userList.Location = new System.Drawing.Point(3, 0);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(296, 193);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lostLabel4);
            this.panel5.Location = new System.Drawing.Point(357, 39);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(308, 254);
            this.panel5.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.sendServerMessage);
            this.panel7.Controls.Add(this.serverChatBox);
            this.panel7.Location = new System.Drawing.Point(5, 440);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(346, 54);
            this.panel7.TabIndex = 14;
            // 
            // sendServerMessage
            // 
            this.sendServerMessage.BackColor = System.Drawing.Color.SeaGreen;
            this.sendServerMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendServerMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendServerMessage.ForeColor = System.Drawing.Color.White;
            this.sendServerMessage.HoverColor = System.Drawing.Color.Green;
            this.sendServerMessage.Image = null;
            this.sendServerMessage.Location = new System.Drawing.Point(284, 8);
            this.sendServerMessage.Name = "sendServerMessage";
            this.sendServerMessage.Size = new System.Drawing.Size(50, 29);
            this.sendServerMessage.TabIndex = 5;
            this.sendServerMessage.Text = "SEND";
            this.sendServerMessage.Click += new System.EventHandler(this.lostAcceptButton1_Click);
            // 
            // serverChatBox
            // 
            this.serverChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.serverChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverChatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.serverChatBox.Location = new System.Drawing.Point(6, 8);
            this.serverChatBox.Name = "serverChatBox";
            this.serverChatBox.Size = new System.Drawing.Size(271, 29);
            this.serverChatBox.TabIndex = 4;
            this.serverChatBox.TextChanged += new System.EventHandler(this.serverChatBox_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 506);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel7);
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
            this.MaximizeBox = false;
            this.Name = "Server";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Text = "SERVER";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.LostAcceptButton startServerButton;
        private ReaLTaiizor.Controls.LostLabel serverLabel;
        private ReaLTaiizor.Controls.CrownTextBox serverIPText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.CrownTextBox serverPortText;
        private ReaLTaiizor.Controls.LostLabel lostLabel1;
        private ReaLTaiizor.Controls.LostAcceptButton stopServerButton;
        private ReaLTaiizor.Controls.LostLabel lostLabel2;
        private ReaLTaiizor.Controls.CrownTextBox serverLogTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.LostLabel lostLabel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton15;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton14;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton12;
        private ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton13;
        private ReaLTaiizor.Controls.LostLabel lostLabel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Panel panel7;
        private ReaLTaiizor.Controls.LostAcceptButton sendServerMessage;
        private ReaLTaiizor.Controls.CrownTextBox serverChatBox;
    }
}

