namespace MatchCards_Client
{
    partial class HelpGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpGuide));
            this.crownTextBox1 = new ReaLTaiizor.Controls.CrownTextBox();
            this.SuspendLayout();
            // 
            // crownTextBox1
            // 
            this.crownTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.crownTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crownTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.crownTextBox1.Location = new System.Drawing.Point(5, 39);
            this.crownTextBox1.Multiline = true;
            this.crownTextBox1.Name = "crownTextBox1";
            this.crownTextBox1.ReadOnly = true;
            this.crownTextBox1.Size = new System.Drawing.Size(426, 348);
            this.crownTextBox1.TabIndex = 0;
            this.crownTextBox1.Text = resources.GetString("crownTextBox1.Text");
            this.crownTextBox1.TextChanged += new System.EventHandler(this.crownTextBox1_TextChanged);
            // 
            // HelpGuide
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 396);
            this.Controls.Add(this.crownTextBox1);
            this.Enabled = false;
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
            this.MaximizeBox = false;
            this.Name = "HelpGuide";
            this.Text = "HELP GUIDE";
            this.Load += new System.EventHandler(this.HelpGuide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.CrownTextBox crownTextBox1;
    }
}