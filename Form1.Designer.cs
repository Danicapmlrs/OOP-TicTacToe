﻿
namespace OOP_TicTacToe
{
    partial class TicTacToe_Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Newgamedrop = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitDrop = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnA1 = new System.Windows.Forms.Button();
            this.BtnA2 = new System.Windows.Forms.Button();
            this.BtnA3 = new System.Windows.Forms.Button();
            this.BtnB1 = new System.Windows.Forms.Button();
            this.BtnB2 = new System.Windows.Forms.Button();
            this.BtnB3 = new System.Windows.Forms.Button();
            this.BtnC1 = new System.Windows.Forms.Button();
            this.BtnC2 = new System.Windows.Forms.Button();
            this.BtnC3 = new System.Windows.Forms.Button();
            this.lblXscore = new System.Windows.Forms.Label();
            this.lbldrawscr = new System.Windows.Forms.Label();
            this.lblOscr = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lbldraw = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.HelpMenu,
            this.AboutMenu});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(370, 28);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            this.MenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Newgamedrop,
            this.ExitDrop});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "File";
            // 
            // Newgamedrop
            // 
            this.Newgamedrop.Name = "Newgamedrop";
            this.Newgamedrop.Size = new System.Drawing.Size(165, 26);
            this.Newgamedrop.Text = "New Game";
            this.Newgamedrop.Click += new System.EventHandler(this.Newgamedrop_Click);
            // 
            // ExitDrop
            // 
            this.ExitDrop.Name = "ExitDrop";
            this.ExitDrop.Size = new System.Drawing.Size(165, 26);
            this.ExitDrop.Text = "Exit";
            this.ExitDrop.Click += new System.EventHandler(this.ExitDrop_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(55, 24);
            this.HelpMenu.Text = "Help";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(64, 24);
            this.AboutMenu.Text = "About";
            // 
            // BtnA1
            // 
            this.BtnA1.Location = new System.Drawing.Point(29, 48);
            this.BtnA1.Name = "BtnA1";
            this.BtnA1.Size = new System.Drawing.Size(94, 90);
            this.BtnA1.TabIndex = 1;
            this.BtnA1.Tag = "\"board\"";
            this.BtnA1.UseVisualStyleBackColor = true;
            this.BtnA1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnA2
            // 
            this.BtnA2.Location = new System.Drawing.Point(139, 48);
            this.BtnA2.Name = "BtnA2";
            this.BtnA2.Size = new System.Drawing.Size(94, 90);
            this.BtnA2.TabIndex = 2;
            this.BtnA2.Tag = "\"board\"";
            this.BtnA2.UseVisualStyleBackColor = true;
            this.BtnA2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnA3
            // 
            this.BtnA3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnA3.Location = new System.Drawing.Point(249, 48);
            this.BtnA3.Name = "BtnA3";
            this.BtnA3.Size = new System.Drawing.Size(94, 90);
            this.BtnA3.TabIndex = 3;
            this.BtnA3.Tag = "\"board\"";
            this.BtnA3.UseVisualStyleBackColor = true;
            this.BtnA3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnB1
            // 
            this.BtnB1.Location = new System.Drawing.Point(29, 153);
            this.BtnB1.Name = "BtnB1";
            this.BtnB1.Size = new System.Drawing.Size(94, 90);
            this.BtnB1.TabIndex = 4;
            this.BtnB1.Tag = "\"board\"";
            this.BtnB1.UseVisualStyleBackColor = true;
            this.BtnB1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnB2
            // 
            this.BtnB2.Location = new System.Drawing.Point(139, 153);
            this.BtnB2.Name = "BtnB2";
            this.BtnB2.Size = new System.Drawing.Size(94, 90);
            this.BtnB2.TabIndex = 5;
            this.BtnB2.Tag = "\"board\"";
            this.BtnB2.UseVisualStyleBackColor = true;
            this.BtnB2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnB3
            // 
            this.BtnB3.Location = new System.Drawing.Point(249, 153);
            this.BtnB3.Name = "BtnB3";
            this.BtnB3.Size = new System.Drawing.Size(94, 90);
            this.BtnB3.TabIndex = 6;
            this.BtnB3.Tag = "\"board\"";
            this.BtnB3.UseVisualStyleBackColor = true;
            this.BtnB3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnC1
            // 
            this.BtnC1.Location = new System.Drawing.Point(29, 261);
            this.BtnC1.Name = "BtnC1";
            this.BtnC1.Size = new System.Drawing.Size(94, 90);
            this.BtnC1.TabIndex = 7;
            this.BtnC1.Tag = "\"board\"";
            this.BtnC1.UseVisualStyleBackColor = true;
            this.BtnC1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnC2
            // 
            this.BtnC2.Location = new System.Drawing.Point(139, 261);
            this.BtnC2.Name = "BtnC2";
            this.BtnC2.Size = new System.Drawing.Size(94, 90);
            this.BtnC2.TabIndex = 8;
            this.BtnC2.Tag = "\"board\"";
            this.BtnC2.UseVisualStyleBackColor = true;
            this.BtnC2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // BtnC3
            // 
            this.BtnC3.Location = new System.Drawing.Point(250, 261);
            this.BtnC3.Name = "BtnC3";
            this.BtnC3.Size = new System.Drawing.Size(94, 90);
            this.BtnC3.TabIndex = 9;
            this.BtnC3.Tag = "\"board\"";
            this.BtnC3.UseVisualStyleBackColor = true;
            this.BtnC3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // lblXscore
            // 
            this.lblXscore.AutoSize = true;
            this.lblXscore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblXscore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblXscore.Location = new System.Drawing.Point(0, 367);
            this.lblXscore.Name = "lblXscore";
            this.lblXscore.Size = new System.Drawing.Size(100, 26);
            this.lblXscore.TabIndex = 10;
            this.lblXscore.Text = "X SCORE";
            // 
            // lbldrawscr
            // 
            this.lbldrawscr.AutoSize = true;
            this.lbldrawscr.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldrawscr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldrawscr.Location = new System.Drawing.Point(106, 367);
            this.lbldrawscr.Name = "lbldrawscr";
            this.lbldrawscr.Size = new System.Drawing.Size(150, 26);
            this.lbldrawscr.TabIndex = 11;
            this.lbldrawscr.Text = "DRAW SCORE";
            // 
            // lblOscr
            // 
            this.lblOscr.AutoSize = true;
            this.lblOscr.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOscr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOscr.Location = new System.Drawing.Point(270, 367);
            this.lblOscr.Name = "lblOscr";
            this.lblOscr.Size = new System.Drawing.Size(100, 26);
            this.lblOscr.TabIndex = 12;
            this.lblOscr.Text = "O SCORE";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblX.ForeColor = System.Drawing.Color.Cyan;
            this.lblX.Location = new System.Drawing.Point(29, 393);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(38, 37);
            this.lblX.TabIndex = 13;
            this.lblX.Text = "0";
            // 
            // lbldraw
            // 
            this.lbldraw.AutoSize = true;
            this.lbldraw.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldraw.ForeColor = System.Drawing.Color.White;
            this.lbldraw.Location = new System.Drawing.Point(157, 393);
            this.lbldraw.Name = "lbldraw";
            this.lbldraw.Size = new System.Drawing.Size(38, 37);
            this.lbldraw.TabIndex = 14;
            this.lbldraw.Text = "0";
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Font = new System.Drawing.Font("Broadway", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblO.ForeColor = System.Drawing.Color.Yellow;
            this.lblO.Location = new System.Drawing.Point(304, 393);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(38, 37);
            this.lblO.TabIndex = 15;
            this.lblO.Text = "0";
            // 
            // TicTacToe_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.lblO);
            this.Controls.Add(this.lbldraw);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblOscr);
            this.Controls.Add(this.lbldrawscr);
            this.Controls.Add(this.lblXscore);
            this.Controls.Add(this.BtnC3);
            this.Controls.Add(this.BtnC2);
            this.Controls.Add(this.BtnC1);
            this.Controls.Add(this.BtnB3);
            this.Controls.Add(this.BtnB2);
            this.Controls.Add(this.BtnB1);
            this.Controls.Add(this.BtnA3);
            this.Controls.Add(this.BtnA2);
            this.Controls.Add(this.BtnA1);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToe_Game";
            this.Text = "TicTacToe";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.Button BtnA1;
        private System.Windows.Forms.Button BtnA2;
        private System.Windows.Forms.Button BtnA3;
        private System.Windows.Forms.Button BtnB1;
        private System.Windows.Forms.Button BtnB2;
        private System.Windows.Forms.Button BtnB3;
        private System.Windows.Forms.Button BtnC1;
        private System.Windows.Forms.Button BtnC2;
        private System.Windows.Forms.Button BtnC3;
        private System.Windows.Forms.ToolStripMenuItem Newgamedrop;
        private System.Windows.Forms.ToolStripMenuItem ExitDrop;
        private System.Windows.Forms.Label lblXscore;
        private System.Windows.Forms.Label lbldrawscr;
        private System.Windows.Forms.Label lblOscr;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lbldraw;
        private System.Windows.Forms.Label lblO;
    }
}

