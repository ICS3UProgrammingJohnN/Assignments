namespace Better21JohnN
{
    partial class frmBetter21
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
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.btnAgain = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayerWins = new System.Windows.Forms.Label();
            this.lblDealerWins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(15, 33);
            this.lblPlayerScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(137, 26);
            this.lblPlayerScore.TabIndex = 0;
            this.lblPlayerScore.Text = "PlayerScore: 0";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(15, 253);
            this.lblDealerScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(141, 26);
            this.lblDealerScore.TabIndex = 1;
            this.lblDealerScore.Text = "DealerScore: 0";
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(572, 430);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 34);
            this.btnHit.TabIndex = 8;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(727, 430);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(75, 34);
            this.btnStay.TabIndex = 9;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.Image = global::Better21JohnN.Properties.Resources.card_back;
            this.picDealerCard3.Location = new System.Drawing.Point(396, 296);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(113, 156);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard3.TabIndex = 7;
            this.picDealerCard3.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.Image = global::Better21JohnN.Properties.Resources.card_back;
            this.picDealerCard2.Location = new System.Drawing.Point(226, 296);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(113, 156);
            this.picDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard2.TabIndex = 6;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard1
            // 
            this.picDealerCard1.Image = global::Better21JohnN.Properties.Resources.card_back;
            this.picDealerCard1.Location = new System.Drawing.Point(44, 296);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(113, 156);
            this.picDealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDealerCard1.TabIndex = 5;
            this.picDealerCard1.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.Image = global::Better21JohnN.Properties.Resources.card_back;
            this.picPlayerCard3.Location = new System.Drawing.Point(396, 62);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(113, 152);
            this.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard3.TabIndex = 4;
            this.picPlayerCard3.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Image = global::Better21JohnN.Properties.Resources.card_back;
            this.picPlayerCard2.Location = new System.Drawing.Point(226, 62);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(113, 152);
            this.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard2.TabIndex = 3;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.Image = global::Better21JohnN.Properties.Resources.card_back;
            this.picPlayerCard1.Location = new System.Drawing.Point(44, 62);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(111, 152);
            this.picPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayerCard1.TabIndex = 2;
            this.picPlayerCard1.TabStop = false;
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(655, 83);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(76, 36);
            this.btnAgain.TabIndex = 10;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(532, 243);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(293, 36);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Text = "The winner is the dealer";
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(861, 24);
            this.mnuMenu.TabIndex = 13;
            this.mnuMenu.Text = "menuStrip";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblPlayerWins
            // 
            this.lblPlayerWins.AutoSize = true;
            this.lblPlayerWins.Location = new System.Drawing.Point(15, 494);
            this.lblPlayerWins.Name = "lblPlayerWins";
            this.lblPlayerWins.Size = new System.Drawing.Size(132, 26);
            this.lblPlayerWins.TabIndex = 14;
            this.lblPlayerWins.Text = "Player Wins: 0";
            // 
            // lblDealerWins
            // 
            this.lblDealerWins.AutoSize = true;
            this.lblDealerWins.Location = new System.Drawing.Point(210, 494);
            this.lblDealerWins.Name = "lblDealerWins";
            this.lblDealerWins.Size = new System.Drawing.Size(134, 26);
            this.lblDealerWins.TabIndex = 15;
            this.lblDealerWins.Text = "Dealer Wins: 0";
            // 
            // frmBetter21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(861, 540);
            this.Controls.Add(this.lblDealerWins);
            this.Controls.Add(this.lblPlayerWins);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.mnuMenu);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmBetter21";
            this.Text = "BlackJack!";
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblPlayerWins;
        private System.Windows.Forms.Label lblDealerWins;
    }
}

