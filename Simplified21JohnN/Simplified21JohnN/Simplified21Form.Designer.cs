namespace Simplified21JohnN
{
    partial class frmSimplified21
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
            this.lblDisplayPlayerScore = new System.Windows.Forms.Label();
            this.lblDisplayDealerScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblDealerScore = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblPlayerCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard2 = new System.Windows.Forms.Label();
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblDealerCard1 = new System.Windows.Forms.Label();
            this.lblDealerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard3 = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplayPlayerScore
            // 
            this.lblDisplayPlayerScore.AutoSize = true;
            this.lblDisplayPlayerScore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPlayerScore.Location = new System.Drawing.Point(104, 21);
            this.lblDisplayPlayerScore.Name = "lblDisplayPlayerScore";
            this.lblDisplayPlayerScore.Size = new System.Drawing.Size(118, 26);
            this.lblDisplayPlayerScore.TabIndex = 0;
            this.lblDisplayPlayerScore.Text = "Player Score:";
            // 
            // lblDisplayDealerScore
            // 
            this.lblDisplayDealerScore.AutoSize = true;
            this.lblDisplayDealerScore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDealerScore.Location = new System.Drawing.Point(111, 255);
            this.lblDisplayDealerScore.Name = "lblDisplayDealerScore";
            this.lblDisplayDealerScore.Size = new System.Drawing.Size(120, 26);
            this.lblDisplayDealerScore.TabIndex = 1;
            this.lblDisplayDealerScore.Text = "Dealer Score:";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(216, 21);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(62, 26);
            this.lblPlayerScore.TabIndex = 2;
            this.lblPlayerScore.Text = "*here*";
            // 
            // lblDealerScore
            // 
            this.lblDealerScore.AutoSize = true;
            this.lblDealerScore.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerScore.Location = new System.Drawing.Point(229, 255);
            this.lblDealerScore.Name = "lblDealerScore";
            this.lblDealerScore.Size = new System.Drawing.Size(62, 26);
            this.lblDealerScore.TabIndex = 3;
            this.lblDealerScore.Text = "*here*";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(168, 192);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(77, 39);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(154, 435);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(77, 40);
            this.btnStay.TabIndex = 6;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblPlayerCard1
            // 
            this.lblPlayerCard1.AutoSize = true;
            this.lblPlayerCard1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard1.Location = new System.Drawing.Point(55, 80);
            this.lblPlayerCard1.Name = "lblPlayerCard1";
            this.lblPlayerCard1.Size = new System.Drawing.Size(52, 65);
            this.lblPlayerCard1.TabIndex = 7;
            this.lblPlayerCard1.Text = "1";
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard2.Location = new System.Drawing.Point(170, 80);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(52, 65);
            this.lblPlayerCard2.TabIndex = 8;
            this.lblPlayerCard2.Text = "2";
            // 
            // lblPlayerCard3
            // 
            this.lblPlayerCard3.AutoSize = true;
            this.lblPlayerCard3.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard3.Location = new System.Drawing.Point(265, 80);
            this.lblPlayerCard3.Name = "lblPlayerCard3";
            this.lblPlayerCard3.Size = new System.Drawing.Size(52, 65);
            this.lblPlayerCard3.TabIndex = 9;
            this.lblPlayerCard3.Text = "3";
            // 
            // lblDealerCard1
            // 
            this.lblDealerCard1.AutoSize = true;
            this.lblDealerCard1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard1.Location = new System.Drawing.Point(55, 331);
            this.lblDealerCard1.Name = "lblDealerCard1";
            this.lblDealerCard1.Size = new System.Drawing.Size(52, 65);
            this.lblDealerCard1.TabIndex = 10;
            this.lblDealerCard1.Text = "1";
            // 
            // lblDealerCard2
            // 
            this.lblDealerCard2.AutoSize = true;
            this.lblDealerCard2.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard2.Location = new System.Drawing.Point(170, 331);
            this.lblDealerCard2.Name = "lblDealerCard2";
            this.lblDealerCard2.Size = new System.Drawing.Size(52, 65);
            this.lblDealerCard2.TabIndex = 11;
            this.lblDealerCard2.Text = "2";
            // 
            // lblDealerCard3
            // 
            this.lblDealerCard3.AutoSize = true;
            this.lblDealerCard3.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard3.Location = new System.Drawing.Point(265, 331);
            this.lblDealerCard3.Name = "lblDealerCard3";
            this.lblDealerCard3.Size = new System.Drawing.Size(52, 65);
            this.lblDealerCard3.TabIndex = 12;
            this.lblDealerCard3.Text = "3";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(109, 138);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(198, 48);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 497);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblDealerCard3);
            this.Controls.Add(this.lblDealerCard2);
            this.Controls.Add(this.lblDealerCard1);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblDealerScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblDisplayDealerScore);
            this.Controls.Add(this.lblDisplayPlayerScore);
            this.Name = "frmSimplified21";
            this.Text = "Black Jack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayPlayerScore;
        private System.Windows.Forms.Label lblDisplayDealerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblPlayerCard1;
        private System.Windows.Forms.Label lblPlayerCard2;
        private System.Windows.Forms.Label lblPlayerCard3;
        private System.Windows.Forms.Label lblDealerCard1;
        private System.Windows.Forms.Label lblDealerCard2;
        private System.Windows.Forms.Label lblDealerCard3;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

