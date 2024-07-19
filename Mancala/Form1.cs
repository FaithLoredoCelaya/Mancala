using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mancala.Classes;


namespace Mancala
{
    public partial class Form1 : Form
    {
        //Create new game
        public BoardSetUp setBUp = new BoardSetUp();

        //Have local copy facilitate data transfer
        private int[] pockets = new int[14];
        private int[] scorePocket = new int[2];

        private int flag = 0;

        public Form1()
        {
            InitializeComponent();
            setBUp.fillCup();
            updateDispaly();
            Turn.Text = "Player Turn: 1";
        }
        private bool checkP1Board()
        {
            bool victory = false;
            int emptySpots = 0;
            for (int i = 0; i < 6; i++)
            {
                if (pockets[i] == 0)
                {
                    emptySpots++;
                }
            }
            if (emptySpots >= 6)
            {
                victory = true;
            }
            else if (emptySpots < 6)
            {
                victory = false;
            }
            return victory;
        }

        private bool checkP2Board()
        {
            bool victory = false;
            int emptySpots = 0;
            for (int i = 6; i < 12; i++)
            {
                if (pockets[i] == 0)
                {
                    emptySpots++;
                }
            }
            if (emptySpots == 6)
            {
                victory = true;
            }
            else if (emptySpots < 6)
            {
                victory = false;
            }
            return victory;
        }

        private int victoryCheck()
        {
            bool p1Victory = false;
            bool p2Victory = false;

            p1Victory = checkP1Board();

            if(p1Victory==true)
            {
                //Player 1 Wins
                if (scorePocket[1] < scorePocket[0])
                {
                    flag = -1;
                    return 1;
                }
                //Player 2 Wins
                if (scorePocket[1] > scorePocket[0])
                {
                    flag = -1;
                    return 2;
                }
            }

            p2Victory = checkP2Board();
            if (p2Victory == true)
            {
                //Player 2 Wins
                if (scorePocket[1] > scorePocket[0])
                {
                    flag = -1;
                    return 2;
                }
                //Player 1 Wins
                if (scorePocket[1] < scorePocket[0])
                {
                    flag = -1;
                    return 1;
                }

            }
            else
            {
                //Nobody has won
                return 0;
            }
            //default return
            return 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void p1Pocket1_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(0,0);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 2";
            }
            else if(flag ==-1)
            {
                //do nothing since game is over
            }

        }

        public void disableOtherPlayerMove()
        {
            //disable the other players controls
            if (setBUp.getPlayerTurn() == 0)
            {
                p1Pocket1.Enabled = true;
                p1Pocket2.Enabled = true;
                p1Pocket3.Enabled = true;
                p1Pocket4.Enabled = true;
                p1Pocket5.Enabled = true;
                p1Pocket6.Enabled = true;

                p2Pocket1.Enabled = false;
                p2Pocket2.Enabled = false;
                p2Pocket3.Enabled = false;
                p2Pocket4.Enabled = false;
                p2Pocket5.Enabled = false;
                p2Pocket6.Enabled = false;
            }
            else if (setBUp.getPlayerTurn() == 1)
            {
                p2Pocket1.Enabled = true;
                p2Pocket2.Enabled = true;
                p2Pocket3.Enabled = true;
                p2Pocket4.Enabled = true;
                p2Pocket5.Enabled = true;
                p2Pocket6.Enabled = true;

                p1Pocket1.Enabled = false;
                p1Pocket2.Enabled = false;
                p1Pocket3.Enabled = false;
                p1Pocket4.Enabled = false;
                p1Pocket5.Enabled = false;
                p1Pocket6.Enabled = false;
            }
        }

        private void p1Pocket2_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(1, 0);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 2";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void StartNew_Click(object sender, EventArgs e)
        {
            ResetGame(setBUp);

        }

        //changes text fields to show current values on the board
        private void updateDispaly()
        {
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            p1Pocket1.Text = pockets[0].ToString();
            p1Pocket2.Text = pockets[1].ToString();
            p1Pocket3.Text = pockets[2].ToString();
            p1Pocket4.Text = pockets[3].ToString();
            p1Pocket5.Text = pockets[4].ToString();
            p1Pocket6.Text = pockets[5].ToString();
            scoreP1.Text = scorePocket[0].ToString();

            p2Pocket1.Text = pockets[6].ToString();
            p2Pocket2.Text = pockets[7].ToString();
            p2Pocket3.Text = pockets[8].ToString();
            p2Pocket4.Text = pockets[9].ToString();
            p2Pocket5.Text = pockets[10].ToString();
            p2Pocket6.Text = pockets[11].ToString();
            scoreP2.Text = scorePocket[1].ToString();


            if (victoryCheck() == 1)
            {
                Turn.Text = "Player 1 won!";
            }
            else if (victoryCheck() == 2)
            {
                Turn.Text = "Player 2 won!";
            }


        }
        private void ResetGame(BoardSetUp setUp)
        {
            //Resets board and fills pockets with peebles
            setBUp.resetGame();
            if (setBUp.getPlayerTurn() != 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            pockets= setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
        }

        private void p1Pocket3_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(2, 0);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 2";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p1Pocket4_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(3, 0);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 2";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p1Pocket5_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(4, 0);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 2";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p1Pocket6_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(5, 0);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 2";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p2Pocket1_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(6, 1);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p2Pocket2_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(7, 1);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p2Pocket3_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(8, 1);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p2Pocket4_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(9, 1);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p2Pocket5_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(10, 1);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }

        private void p2Pocket6_Click(object sender, EventArgs e)
        {
            flag = setBUp.updateValues(11, 1);
            updateDispaly();
            if (flag == 0)
            {
                setBUp.switchPlayer();
                disableOtherPlayerMove();
                Turn.Text = "Player Turn: 1";
            }
            else if (flag == -1)
            {
                //do nothing since game is over
            }
        }
    }
}
