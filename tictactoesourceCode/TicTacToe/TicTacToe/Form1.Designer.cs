namespace TicTacToe
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Square9 = new System.Windows.Forms.Panel();
            this.Square8 = new System.Windows.Forms.Panel();
            this.Square7 = new System.Windows.Forms.Panel();
            this.Square6 = new System.Windows.Forms.Panel();
            this.Square5 = new System.Windows.Forms.Panel();
            this.Square4 = new System.Windows.Forms.Panel();
            this.Square3 = new System.Windows.Forms.Panel();
            this.Square2 = new System.Windows.Forms.Panel();
            this.Square1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.playerWin = new System.Windows.Forms.TextBox();
            this.computerWin = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Square9);
            this.groupBox1.Controls.Add(this.Square8);
            this.groupBox1.Controls.Add(this.Square7);
            this.groupBox1.Controls.Add(this.Square6);
            this.groupBox1.Controls.Add(this.Square5);
            this.groupBox1.Controls.Add(this.Square4);
            this.groupBox1.Controls.Add(this.Square3);
            this.groupBox1.Controls.Add(this.Square2);
            this.groupBox1.Controls.Add(this.Square1);
            this.groupBox1.Location = new System.Drawing.Point(325, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Square9
            // 
            this.Square9.Location = new System.Drawing.Point(313, 257);
            this.Square9.Name = "Square9";
            this.Square9.Size = new System.Drawing.Size(135, 104);
            this.Square9.TabIndex = 7;
            this.Square9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square9_MouseDown);
            // 
            // Square8
            // 
            this.Square8.Location = new System.Drawing.Point(171, 257);
            this.Square8.Name = "Square8";
            this.Square8.Size = new System.Drawing.Size(124, 104);
            this.Square8.TabIndex = 6;
            this.Square8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square8_MouseDown);
            // 
            // Square7
            // 
            this.Square7.Location = new System.Drawing.Point(7, 257);
            this.Square7.Name = "Square7";
            this.Square7.Size = new System.Drawing.Size(141, 104);
            this.Square7.TabIndex = 5;
            this.Square7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square7_MouseDown);
            // 
            // Square6
            // 
            this.Square6.Location = new System.Drawing.Point(313, 148);
            this.Square6.Name = "Square6";
            this.Square6.Size = new System.Drawing.Size(135, 87);
            this.Square6.TabIndex = 4;
            this.Square6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square6_MouseDown);
            // 
            // Square5
            // 
            this.Square5.Location = new System.Drawing.Point(171, 148);
            this.Square5.Name = "Square5";
            this.Square5.Size = new System.Drawing.Size(124, 87);
            this.Square5.TabIndex = 3;
            this.Square5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square5_MouseDown);
            // 
            // Square4
            // 
            this.Square4.Location = new System.Drawing.Point(7, 148);
            this.Square4.Name = "Square4";
            this.Square4.Size = new System.Drawing.Size(141, 87);
            this.Square4.TabIndex = 1;
            this.Square4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square4_MouseDown);
            // 
            // Square3
            // 
            this.Square3.Location = new System.Drawing.Point(313, 20);
            this.Square3.Name = "Square3";
            this.Square3.Size = new System.Drawing.Size(135, 100);
            this.Square3.TabIndex = 2;
            this.Square3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square3_MouseDown);
            // 
            // Square2
            // 
            this.Square2.Location = new System.Drawing.Point(171, 19);
            this.Square2.Name = "Square2";
            this.Square2.Size = new System.Drawing.Size(124, 100);
            this.Square2.TabIndex = 1;
            this.Square2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square2_MouseDown);
            // 
            // Square1
            // 
            this.Square1.Location = new System.Drawing.Point(7, 20);
            this.Square1.Name = "Square1";
            this.Square1.Size = new System.Drawing.Size(141, 100);
            this.Square1.TabIndex = 0;
            this.Square1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Square1_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(270, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to Tic Tac Toe";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 247);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(114, 15);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Player One Win";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(133, 247);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(149, 15);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Computer Player Win";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 24);
            this.menuStrip1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.Items.AddRange(new object[] {
            "Level1",
            "Level2"});
            this.listBox1.Location = new System.Drawing.Point(14, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Enabled = false;
            this.playAgainButton.Location = new System.Drawing.Point(14, 382);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(100, 38);
            this.playAgainButton.TabIndex = 9;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // playerWin
            // 
            this.playerWin.BackColor = System.Drawing.SystemColors.Control;
            this.playerWin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWin.Location = new System.Drawing.Point(0, 311);
            this.playerWin.Name = "playerWin";
            this.playerWin.ReadOnly = true;
            this.playerWin.Size = new System.Drawing.Size(100, 22);
            this.playerWin.TabIndex = 11;
            this.playerWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // computerWin
            // 
            this.computerWin.BackColor = System.Drawing.SystemColors.Control;
            this.computerWin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerWin.Location = new System.Drawing.Point(120, 311);
            this.computerWin.Name = "computerWin";
            this.computerWin.ReadOnly = true;
            this.computerWin.Size = new System.Drawing.Size(100, 22);
            this.computerWin.TabIndex = 12;
            this.computerWin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(14, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(230, 63);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Select a level to Begin\n   Level1: Easy\n   Level2: Difficult ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 475);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.computerWin);
            this.Controls.Add(this.playerWin);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        protected System.Windows.Forms.Panel Square1;
        protected System.Windows.Forms.Panel Square2;
        protected System.Windows.Forms.Panel Square3;
        protected System.Windows.Forms.Panel Square4;
        protected System.Windows.Forms.Panel Square5;
        protected System.Windows.Forms.Panel Square6;
        protected System.Windows.Forms.Panel Square7;
        protected System.Windows.Forms.Panel Square8;
        protected System.Windows.Forms.Panel Square9;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.TextBox playerWin;
        private System.Windows.Forms.TextBox computerWin;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

