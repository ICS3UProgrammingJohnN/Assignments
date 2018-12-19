/*
 * Created by: John Ngundeng
 * Created on: December 18, 2018
 * Created for: ICS3U Programming
 * Assignment #7b - A Better 21
 * This program is better version of the assignment 6b.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Better21JohnN
{
    public partial class frmBetter21 : Form
    {
        // declaring global variables and constants
        const int MIN_CARDS = 0;
        int maxCards = 52 ;
        int pCard1, pCard2, dCard1, dCard2, dCard3;
        int playerScore, dealerScore;
        int dWins,pWins;

        // creating an empty deck to insert the cards
        List<Image> listCardImages = new List<Image>();
        List<int> listCardValues = new List<int>();
        Random randomNumberGenerator = new Random();

        public frmBetter21()
        {
            InitializeComponent();

            // disable buttons
            btnAgain.Enabled = false;

            //
            this.lblWinner.Hide();

            // filling the array with the cards
            FillDeck();
            // setting the new max to be the length of 
            maxCards = listCardImages.Count()-1;
            // generating a random number 
            pCard1 = randomNumberGenerator.Next(MIN_CARDS, maxCards );
            pCard2 = randomNumberGenerator.Next(MIN_CARDS, maxCards );

            //   
            picPlayerCard1.Image = listCardImages[pCard1];
            picPlayerCard2.Image = listCardImages[pCard2];

            // setting the score to be the sum of both cards
            playerScore = listCardValues[pCard1] + listCardValues[pCard2];

            listCardImages.RemoveAt(pCard1);
            listCardImages.RemoveAt(pCard2);
            listCardValues.RemoveAt(pCard1);
            listCardValues.RemoveAt(pCard2);

            

            // displaying the score to user
            this.lblPlayerScore.Text = "PlayerScore: " + playerScore;
            this.ShuffleCards();
        }
        private void ShuffleCards()
        {
            if (listCardValues.Count()<6)
            {
                this.FillDeck();
                MessageBox.Show("Cards have been shuffled");
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // enabling the buttons
            btnHit.Enabled = true;
            btnStay.Enabled = true;
            btnAgain.Enabled = false;

            //hiding text
            this.lblWinner.Hide();

            // setting the new max to be the length of 
            maxCards = listCardImages.Count()-1;

            // generating a random number 
            pCard1 = randomNumberGenerator.Next(MIN_CARDS, maxCards );
            pCard2 = randomNumberGenerator.Next(MIN_CARDS, maxCards );

            //   
            picPlayerCard1.Image = listCardImages[pCard1];
            picPlayerCard2.Image = listCardImages[pCard2];

            // setting the score to be the sum of both cards
            playerScore = listCardValues[pCard1] + listCardValues[pCard2];

            // adding up the player score 
            dealerScore = 0;

            listCardImages.RemoveAt(pCard1);
            listCardImages.RemoveAt(pCard2);
            listCardValues.RemoveAt(pCard1);
            listCardValues.RemoveAt(pCard2);

            //
            picPlayerCard3.Image = Properties.Resources.card_back;
            picDealerCard1.Image = Properties.Resources.card_back;
            picDealerCard2.Image = Properties.Resources.card_back;
            picDealerCard3.Image = Properties.Resources.card_back;

            // clearing score
            this.lblPlayerScore.Text = "PlayerScore: " + playerScore;
            this.lblDealerScore.Text = "DealerScore: " + dealerScore;

            this.ShuffleCards();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exits the program
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void FillDeck()
        {
            // adding the image to each index
            listCardImages.Insert(0, Properties.Resources._1);
            listCardImages.Insert(1, Properties.Resources._2);
            listCardImages.Insert(2, Properties.Resources._3);
            listCardImages.Insert(3, Properties.Resources._4);
            listCardImages.Insert(4, Properties.Resources._5);
            listCardImages.Insert(5, Properties.Resources._6);
            listCardImages.Insert(6, Properties.Resources._7);
            listCardImages.Insert(7, Properties.Resources._8);
            listCardImages.Insert(8, Properties.Resources._9);
            listCardImages.Insert(9, Properties.Resources._10);
            listCardImages.Insert(10, Properties.Resources._11);
            listCardImages.Insert(11, Properties.Resources._12);
            listCardImages.Insert(12, Properties.Resources._13);
            listCardImages.Insert(13, Properties.Resources._14);
            listCardImages.Insert(14, Properties.Resources._15);
            listCardImages.Insert(15, Properties.Resources._16);
            listCardImages.Insert(16, Properties.Resources._17);
            listCardImages.Insert(17, Properties.Resources._18);
            listCardImages.Insert(18, Properties.Resources._19);
            listCardImages.Insert(19, Properties.Resources._20);
            listCardImages.Insert(20, Properties.Resources._21);
            listCardImages.Insert(21, Properties.Resources._22);
            listCardImages.Insert(22, Properties.Resources._23);
            listCardImages.Insert(23, Properties.Resources._24);
            listCardImages.Insert(24, Properties.Resources._25);
            listCardImages.Insert(25, Properties.Resources._26);
            listCardImages.Insert(26, Properties.Resources._27);
            listCardImages.Insert(27, Properties.Resources._28);
            listCardImages.Insert(28, Properties.Resources._29);
            listCardImages.Insert(29, Properties.Resources._30);
            listCardImages.Insert(30, Properties.Resources._31);
            listCardImages.Insert(31, Properties.Resources._32);
            listCardImages.Insert(32, Properties.Resources._33);
            listCardImages.Insert(33, Properties.Resources._34);
            listCardImages.Insert(34, Properties.Resources._35);
            listCardImages.Insert(35, Properties.Resources._36);
            listCardImages.Insert(36, Properties.Resources._37);
            listCardImages.Insert(37, Properties.Resources._38);
            listCardImages.Insert(38, Properties.Resources._39);
            listCardImages.Insert(39, Properties.Resources._40);
            listCardImages.Insert(40, Properties.Resources._41);
            listCardImages.Insert(41, Properties.Resources._42);
            listCardImages.Insert(42, Properties.Resources._43);
            listCardImages.Insert(43, Properties.Resources._44);
            listCardImages.Insert(44, Properties.Resources._45);
            listCardImages.Insert(45, Properties.Resources._46);
            listCardImages.Insert(46, Properties.Resources._47);
            listCardImages.Insert(47, Properties.Resources._48);
            listCardImages.Insert(48, Properties.Resources._49);
            listCardImages.Insert(49, Properties.Resources._50);
            listCardImages.Insert(50, Properties.Resources._51);
            listCardImages.Insert(51, Properties.Resources._52);


            //
            listCardValues.Insert(0,1);
            listCardValues.Insert(1,1);
            listCardValues.Insert(2,1);
            listCardValues.Insert(3,1);
            listCardValues.Insert(4,2);
            listCardValues.Insert(5,2);
            listCardValues.Insert(6,2);
            listCardValues.Insert(7,2);
            listCardValues.Insert(8,3);
            listCardValues.Insert(9,3);
            listCardValues.Insert(10,3);
            listCardValues.Insert(11,3);
            listCardValues.Insert(12,4);
            listCardValues.Insert(13,4);
            listCardValues.Insert(14,4);
            listCardValues.Insert(15,4);
            listCardValues.Insert(16,5);
            listCardValues.Insert(17,5);
            listCardValues.Insert(18,5);
            listCardValues.Insert(19,5);
            listCardValues.Insert(20,6);
            listCardValues.Insert(21,6);
            listCardValues.Insert(22,6);
            listCardValues.Insert(23,6);
            listCardValues.Insert(24,7);
            listCardValues.Insert(25,7);
            listCardValues.Insert(26,7);
            listCardValues.Insert(27,7);
            listCardValues.Insert(28,8);
            listCardValues.Insert(29,8);
            listCardValues.Insert(30,8);
            listCardValues.Insert(31,8);
            listCardValues.Insert(32,9);
            listCardValues.Insert(33,9);
            listCardValues.Insert(34,9);
            listCardValues.Insert(35,9);
            listCardValues.Insert(36,10);
            listCardValues.Insert(37,10);
            listCardValues.Insert(38,10);
            listCardValues.Insert(39,10);
            listCardValues.Insert(40,10);
            listCardValues.Insert(41,10);
            listCardValues.Insert(42,10);
            listCardValues.Insert(43,10);
            listCardValues.Insert(44,10);
            listCardValues.Insert(45,10);
            listCardValues.Insert(46,10);
            listCardValues.Insert(47,10);
            listCardValues.Insert(48,10);
            listCardValues.Insert(49,10);
            listCardValues.Insert(50,10);
            listCardValues.Insert(51,10);
        }

        private int DealCards(int Score)
        {
            // generating a random number 
            dCard1 = randomNumberGenerator.Next(MIN_CARDS, maxCards);
            dCard2 = randomNumberGenerator.Next(MIN_CARDS, maxCards);
            dCard3 = randomNumberGenerator.Next(MIN_CARDS, maxCards);

            // setting the new max to be the length of 
            maxCards = listCardImages.Count() - 1;

            // adding the correct image to the pic box
            picDealerCard1.Image = listCardImages[dCard1];
            picDealerCard2.Image = listCardImages[dCard2];
            picDealerCard3.Image = listCardImages[dCard3];

            // setting the score to be the sum of both cards
            dealerScore = listCardValues[dCard1] + listCardValues[dCard2] + listCardValues[dCard3];

            // removing the used cards
            listCardImages.RemoveAt(dCard1);
            listCardImages.RemoveAt(dCard2);
            listCardValues.RemoveAt(dCard1);
            listCardValues.RemoveAt(dCard2);

            //
            

            // displaying the score to user
            this.lblDealerScore.Text = "DealerScore: " + dealerScore;

            this.ShuffleCards();

            if (playerScore == dealerScore)
            {
                if (dealerScore >= 21)
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "The winner is the dealer";
                    btnAgain.Enabled = true;
                    dWins = dWins + 1;
                    this.lblDealerWins.Text = "DealerWins: " + dWins;
                }
                else
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "It's a draw";
                    btnAgain.Enabled = true;

                }
            }
            else if (playerScore > dealerScore)
            {
                if (playerScore > 21)
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "The winner is the dealer";
                    btnAgain.Enabled = true;
                    dWins = dWins + 1;
                    this.lblDealerWins.Text = "DealerWins: " + 1;

                }
                else
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "You Win!!!";
                    btnAgain.Enabled = true;
                    pWins = pWins + 1;
                    this.lblPlayerWins.Text = "PlayerWins: " + pWins;
                }
            }
            else
            {
                if (playerScore > 21)
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "The winner is the dealer";
                    btnAgain.Enabled = true;
                    dWins = dWins + 1;
                    this.lblDealerWins.Text = "DealerWins: " + dWins;
                }
                else if (playerScore == 21)
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "You Win!!!";
                    btnAgain.Enabled = true;
                    pWins = pWins + 1;
                    this.lblPlayerWins.Text = "PlayerWins: " + pWins;

                }
                else if (dealerScore > 21)
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "You Win!!!";
                    btnAgain.Enabled = true;
                    pWins = pWins + 1;
                    this.lblPlayerWins.Text = "PlayerWins: " + pWins;

                }
                else
                {
                    this.lblWinner.Show();
                    this.lblWinner.Text = "The winner is the dealer";
                    btnAgain.Enabled = true;
                    dWins = dWins + 1;
                    this.lblDealerWins.Text = "DealerWins: " + dWins;

                }
            }
            return Score;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {

            // disabling the buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            // declare variable
            int pCard3;
            // setting the new max to be the length of 
            maxCards = listCardImages.Count()-1;
            // generating a random number 
            pCard3 = randomNumberGenerator.Next(MIN_CARDS, maxCards );


            //   
            picPlayerCard3.Image = listCardImages[pCard3];

            if (pCard1 >= listCardValues.Count())
            {
                pCard1 = listCardValues.Count() - 1;
            }

            if (pCard2 >= listCardValues.Count())
            {
                pCard2 = listCardValues.Count() - 1;
            }

            if (pCard3 >= listCardValues.Count())
            {
                pCard3 = listCardValues.Count() - 1;
            }



            // setting the score to be the sum of both cards
            playerScore = listCardValues[pCard1] + listCardValues[pCard2] + listCardValues[pCard3];

            listCardImages.RemoveAt(pCard3);
            listCardValues.RemoveAt(pCard3);


            

            // displaying the score to user
            this.lblPlayerScore.Text = "PlayerScore: " + playerScore;

            // call function
            this.DealCards(playerScore);

            this.ShuffleCards();
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            // disabling the buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            // setting the new max to be the length of 
            maxCards = listCardImages.Count()-1;

            if (pCard1 >= listCardValues.Count())
            {
                pCard1 = listCardValues.Count() - 1;
            }

            if (pCard2 >= listCardValues.Count())
            {
                pCard2 = listCardValues.Count() - 1;
            }

            // setting the score to be the sum of both cards
            playerScore = listCardValues[pCard1] + listCardValues[pCard2];

            // call function
            this.DealCards(playerScore);

            this.ShuffleCards();
        }
        private void btnExit_Click(object sender, EventArgs e){ }
    }
}
