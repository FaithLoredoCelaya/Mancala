using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala.Classes
{
    public class BoardSetUp
    {
        public int totalPeebles = 48;

        public int peeblePerCup = 4;
        int playerTurn = 0;
        int[] pocket = new int[12];
        int[] scorePocket = new int[2];

        public int getPlayerTurn()
        {
            return playerTurn;
        }

        public int[] getPocketScores()
        {
            return pocket;
        }

        public int[] getScorePockets()
        {
            return scorePocket;
        }

        public void switchPlayer()
        {
            if (playerTurn == 0)
            {
                playerTurn = 1;
            }
            else
            {
                playerTurn = 0;
            }
        }

        //Fills the cup with the peebles per cup as indicated by the limits avobe
        public void  fillCup()
        {
            for (int i=0;i<12;i++)
            {
                pocket[i] = peeblePerCup;
            }
        }

        public void resetGame()
        {
            fillCup();
            scorePocket[0] = 0;
            scorePocket[1] = 0;
        }

        //Checks if the peebles are under the limit set up avobe
        public bool maxedCups(int tPeebles)
        {
            if (tPeebles <= totalPeebles)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Updates the pockets. moving the pebbles one at at time to the next pocket just like in the real game.
        public void  updateValues(int intial,int turn)
        {
            //set up the number of pebbles we need to move
            int toMove = pocket[intial];
            //See which pocket we are in
            int counter = intial;
            //empty the initial pocket
            pocket[intial] = 0;
            
            if (turn == 0)
            {
                //move to the next pocket
                counter++;
                for (int i = 0; i < toMove; i++)
                {
                    //Check if the pocket is a score pocket
                    if (counter == 6)
                    {
                        //Add score if it is
                        scorePocket[turn]++;
                    }
                    else
                    {
                        //Else just add one to the next pocket
                        pocket[counter] = pocket[counter] + 1;
                    }

                    counter++;


                }
            } else if(turn==1)
            {
                //move to the next pocket
                counter++;
                for (int i = 0; i < toMove; i++)
                {
                    //Check if the pocket is a score pocket
                    if (counter == 12)
                    {
                        //Add score if it is
                        scorePocket[turn]++;
                    }
                    else
                    {
                        //Else just add one to the next pocket
                        pocket[counter] = pocket[counter] + 1;
                    }

                    counter++;

                    //if the counter is more than the avialble pockets. reset to zero to loop around
                    if (counter == 13)
                    {
                        counter = 0;
                    }

                }
            }
        }
    }

}
