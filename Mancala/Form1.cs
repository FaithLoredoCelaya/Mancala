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
           // setBUp.switchPlayer();
            //Turn.Text = "Player Turn: 2";

        }

        private void p1Pocket2_Click(object sender, EventArgs e)
        {
            setBUp.updateValues(1, 0);
            pockets = setBUp.getPocketScores();
            scorePocket = setBUp.getScorePockets();
            updateDispaly();
         //   setBUp.switchPlayer();
         //   Turn.Text = "Player Turn: 2";
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


    }
}
