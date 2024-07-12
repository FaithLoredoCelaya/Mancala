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
        int[] pockets = new int[12];
        int[] scorePocket = new int[2];

        public Form1()
        {
            InitializeComponent();
            setBUp.fillCup();
            updateDispaly();
            Turn.Text = "Player Turn: 1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void p1Pocket1_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(0,0);
            pockets= setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 2";

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
            setBUp.updateValues(1, 0);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 2";
        }

        private void StartNew_Click(object sender, EventArgs e)
        {
            ResetGame(setBUp);

        }

        //changes text fields to show current values on the board
        private void updateDispaly()
        {
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

        }
        private void ResetGame(BoardSetUp setUp)
        {
            //Resets board and fills pockets with peebles
            setBUp.resetGame();
            pockets= setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
        }

        private void p1Pocket3_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(2, 0);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 2";
        }

        private void p1Pocket4_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(3, 0);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 2";
        }

        private void p1Pocket5_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(4, 0);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 2";
        }

        private void p1Pocket6_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(11, 0);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 2";
        }

        private void p2Pocket1_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(10, 1);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 1";
        }

        private void p2Pocket2_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(9, 1);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 1";
        }

        private void p2Pocket3_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(8, 1);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 1";
        }

        private void p2Pocket4_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(7, 1);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 1";
        }

        private void p2Pocket5_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(6, 1);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 1";
        }

        private void p2Pocket6_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(5, 1);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
            setBUp.switchPlayer();
            disableOtherPlayerMove();
            Turn.Text = "Player Turn: 1";
        }
    }
}
