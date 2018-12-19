using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21JohnN
{
    public partial class frmSimplified21 : Form
    {
        // declaring global variables and constants
        const int MIN_NUM = 1;
        const int MAX_NUM = 10;
        int pCard1, pCard2, dCard1, dCard2, dCard3;
        int playerScore, dealerScore;

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // hiding the cards
            this.lblDealerCard1.Hide();
            this.lblDealerCard2.Hide();
            this.lblDealerCard3.Hide();
            this.lblPlayerCard3.Hide();
            this.btnPlayAgain.Hide();

            // enabling the buttons
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            // Generating a random number for the cards
            pCard1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            pCard2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // converting number to string
            lblPlayerCard1.Text = Convert.ToString(pCard1);
            lblPlayerCard2.Text = Convert.ToString(pCard2);

            // adding up the player score 
            playerScore = pCard1 + pCard2;

            // adding up the player score 
            dealerScore = 0;

            // clearing score
            lblDealerScore.Text = Convert.ToString(dealerScore);
            lblPlayerScore.Text = Convert.ToString(playerScore);
        }

        Random randomNumberGenerator = new Random();

        public frmSimplified21()
        {
            InitializeComponent();
            // hiding the cards
            this.lblDealerCard1.Hide();
            this.lblDealerCard2.Hide();
            this.lblDealerCard3.Hide();
            this.lblPlayerCard3.Hide();
            this.btnPlayAgain.Hide();

            // Generating a random number for the cards
            pCard1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            pCard2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // converting number to string
            lblPlayerCard1.Text = Convert.ToString(pCard1);
            lblPlayerCard2.Text = Convert.ToString(pCard2);

            // adding up the player score 
            playerScore = pCard1 + pCard2;

            lblPlayerScore.Text = Convert.ToString(playerScore);

        }
        private void DealCards( int playerScore )
        {
            // Generating a random number for the cards
            dCard1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dCard2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dCard3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // converting number to string
            lblDealerCard1.Text = Convert.ToString(dCard1);
            lblDealerCard2.Text = Convert.ToString(dCard2);
            lblDealerCard3.Text = Convert.ToString(dCard3);

            // adding up the dealer score 
            dealerScore = dCard1 + dCard2 + dCard3;

            lblDealerScore.Text = Convert.ToString(dealerScore);

            // showing all the dealers cards
            this.lblDealerCard1.Show();
            this.lblDealerCard2.Show();
            this.lblDealerCard3.Show();

            if (playerScore == dealerScore)
            {
                if (dealerScore >= 21)
                {
                    MessageBox.Show("Dealer Wins");
                    this.btnPlayAgain.Show();
                }
                else
                {
                    MessageBox.Show("It's a draw");
                    this.btnPlayAgain.Show();
                }
            }
            else if (playerScore > dealerScore)
            {
                if (playerScore > 21)
                {
                    MessageBox.Show("Dealer Wins");
                    this.btnPlayAgain.Show();
                }
                else
                {
                    MessageBox.Show("You Win");
                    this.btnPlayAgain.Show();
                }
            }
            else
            {
                if (playerScore > 21)
                {
                    MessageBox.Show("Dealer Wins");
                    this.btnPlayAgain.Show();
                }
                else if (playerScore == 21)
                {
                    MessageBox.Show("You Win");
                    this.btnPlayAgain.Show();
                }
                else if (dealerScore > 21)
                {
                    MessageBox.Show("You Win");
                    this.btnPlayAgain.Show();
                }
                else
                {
                    MessageBox.Show("Dealer Wins");
                    this.btnPlayAgain.Show();
                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // disabling the buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

        

            // adding up the player score 
            playerScore = pCard1 + pCard2;

            // Converting score to string
            lblPlayerScore.Text = Convert.ToString(playerScore);

            this.DealCards(playerScore); 

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            // declaring variables 
            int pCard3;

            // generating a random number for card 3
            pCard3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // converting number to string
            lblPlayerCard3.Text = Convert.ToString(pCard3);

            // showing the third card
            this.lblPlayerCard3.Show();

            // adding the number to players score
            playerScore = playerScore + pCard3;

            //converting the score to a string
            lblPlayerScore.Text = Convert.ToString(playerScore);

            // disabling the button
            btnStay.Enabled = false;
            btnHit.Enabled = false;

            // calling the deal cards function
            this.DealCards(playerScore);

        }
    }
}
