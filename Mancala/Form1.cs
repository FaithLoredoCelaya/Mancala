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
        public BoardSetUp setBUp = new BoardSetUp();
        public int spacesToMove = 0;
        public int playerTurn = 1;


        public Form1()
        {
            InitializeComponent();
            ResetGame(setBUp);
            Turn.Text = "Player Turn: " + playerTurn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void p1Pocket1_Click(object sender, EventArgs e)
        {
            spacesToMove = Int32.Parse(p1Pocket1.Text);
            playerTurn=2;
            Turn.Text = "Player Turn: 2";

        }

        private void p1Pocket2_Click(object sender, EventArgs e)
        {

        }

        private void StartNew_Click(object sender, EventArgs e)
        {
            ResetGame(setBUp);
        }

        private void ResetGame(BoardSetUp setUp)
        {
            //Resets board and fills pockets with peebles
            p1Pocket1.Text = setBUp.fillCup();
            p1Pocket2.Text = setBUp.fillCup();
            p1Pocket3.Text = setBUp.fillCup();
            p1Pocket4.Text = setBUp.fillCup();
            p1Pocket5.Text = setBUp.fillCup();
            p1Pocket6.Text = setBUp.fillCup();

            p2Pocket1.Text = setBUp.fillCup();
            p2Pocket2.Text = setBUp.fillCup();
            p2Pocket3.Text = setBUp.fillCup();
            p2Pocket4.Text = setBUp.fillCup();
            p2Pocket5.Text = setBUp.fillCup();
            p2Pocket6.Text = setBUp.fillCup();
        }

        private void UpdatePeebles(int toMove, string p, int pocket)
        {
            if (p == "p1")
            {
/*                switch (pocket)
                {
              case 1:
                        int result = Int32.Parse(p1Pocket1.Text) - 1;
                        p1Pocket1.Text = result;
                    default:      
                    
                }*/
            }
            
        }

    }
}
