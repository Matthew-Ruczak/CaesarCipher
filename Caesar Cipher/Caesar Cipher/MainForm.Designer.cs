namespace Caesar_Cipher
{
    partial class MainForm
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
            this.CipheredTextrichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextToBeCipheredrichTextBox = new System.Windows.Forms.RichTextBox();
            this.TypeOfCiphertrackBar = new System.Windows.Forms.TrackBar();
            this.TypeOfCaesarCipherlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FiletoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCaesarCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDoesItWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfCiphertrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CipheredTextrichTextBox
            // 
            this.CipheredTextrichTextBox.Location = new System.Drawing.Point(12, 246);
            this.CipheredTextrichTextBox.Name = "CipheredTextrichTextBox";
            this.CipheredTextrichTextBox.ReadOnly = true;
            this.CipheredTextrichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CipheredTextrichTextBox.Size = new System.Drawing.Size(303, 102);
            this.CipheredTextrichTextBox.TabIndex = 1;
            this.CipheredTextrichTextBox.Text = "";
            // 
            // TextToBeCipheredrichTextBox
            // 
            this.TextToBeCipheredrichTextBox.Location = new System.Drawing.Point(12, 45);
            this.TextToBeCipheredrichTextBox.Name = "TextToBeCipheredrichTextBox";
            this.TextToBeCipheredrichTextBox.Size = new System.Drawing.Size(303, 114);
            this.TextToBeCipheredrichTextBox.TabIndex = 2;
            this.TextToBeCipheredrichTextBox.Text = "";
            this.TextToBeCipheredrichTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextToBeCipheredrichTextBox_KeyUp);
            // 
            // TypeOfCiphertrackBar
            // 
            this.TypeOfCiphertrackBar.Location = new System.Drawing.Point(91, 174);
            this.TypeOfCiphertrackBar.Maximum = 26;
            this.TypeOfCiphertrackBar.Name = "TypeOfCiphertrackBar";
            this.TypeOfCiphertrackBar.Size = new System.Drawing.Size(190, 45);
            this.TypeOfCiphertrackBar.TabIndex = 3;
            // 
            // TypeOfCaesarCipherlabel
            // 
            this.TypeOfCaesarCipherlabel.AutoSize = true;
            this.TypeOfCaesarCipherlabel.Location = new System.Drawing.Point(287, 184);
            this.TypeOfCaesarCipherlabel.Name = "TypeOfCaesarCipherlabel";
            this.TypeOfCaesarCipherlabel.Size = new System.Drawing.Size(13, 13);
            this.TypeOfCaesarCipherlabel.TabIndex = 4;
            this.TypeOfCaesarCipherlabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your text here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ciphered text will appear here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Set your key:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(329, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiletoolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FiletoolStripMenuItem
            // 
            this.FiletoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCaesarCipherToolStripMenuItem});
            this.FiletoolStripMenuItem.Name = "FiletoolStripMenuItem";
            this.FiletoolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FiletoolStripMenuItem.Text = "File";
            // 
            // newCaesarCipherToolStripMenuItem
            // 
            this.newCaesarCipherToolStripMenuItem.Name = "newCaesarCipherToolStripMenuItem";
            this.newCaesarCipherToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newCaesarCipherToolStripMenuItem.Text = "New Caesar Cipher";
            this.newCaesarCipherToolStripMenuItem.Click += new System.EventHandler(this.newCaesarCipherToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howDoesItWorkToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howDoesItWorkToolStripMenuItem
            // 
            this.howDoesItWorkToolStripMenuItem.Name = "howDoesItWorkToolStripMenuItem";
            this.howDoesItWorkToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.howDoesItWorkToolStripMenuItem.Text = "How does it work?";
            this.howDoesItWorkToolStripMenuItem.Click += new System.EventHandler(this.howDoesItWorkToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(329, 382);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfCaesarCipherlabel);
            this.Controls.Add(this.TypeOfCiphertrackBar);
            this.Controls.Add(this.TextToBeCipheredrichTextBox);
            this.Controls.Add(this.CipheredTextrichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher Alpha";
            ((System.ComponentModel.ISupportInitialize)(this.TypeOfCiphertrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CipheredTextrichTextBox;
        private System.Windows.Forms.RichTextBox TextToBeCipheredrichTextBox;
        private System.Windows.Forms.TrackBar TypeOfCiphertrackBar;
        private System.Windows.Forms.Label TypeOfCaesarCipherlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FiletoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCaesarCipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDoesItWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

