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
        int[] pocket = new int[14];
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

        //obtain pocket number across the field
        public int getOpposite(int counter)
        {
            if (counter==0)
                return 11;
            else if (counter==1)
                return 10;
            else if (counter == 2)
                return 9;
            else if (counter == 3)
                return 8;
            else if (counter == 4)
                return 7;
            else if (counter == 5)
                return 6;
            else if (counter == 6)
                return 5;
            else if (counter == 7)
                return 4;
            else if (counter == 8)
                return 3;
            else if (counter == 9)
                return 2;
            else if (counter == 10)
                return 1;
            else if (counter == 11)
                return 0;
            else
                return -1;
            
        }

        //Updates the pockets. moving the pebbles one at at time to the next pocket just like in the real game.
        public int  updateValues(int intial,int turn)
        {
            //set up the number of pebbles we need to move
            int toMove = pocket[intial];
            //See which pocket we are in
            int counter = intial;
            //empty the initial pocket
            pocket[intial] = 0;
            //operator
            int calculator = 0;
            
            if (turn == 0)
            {
                for (int i = 1; i <= toMove; i++)
                {
                    //move to the next pocket
                    counter++;
                    //Check if you can steal
                    if (counter > -1 && counter < 6)
                    {
                        if (i == toMove && pocket[counter] == 0)
                        {
                            calculator = getOpposite(counter);
                            scorePocket[0] = scorePocket[0] + pocket[calculator];
                            pocket[calculator] = 0;
                            pocket[counter] = 0;
                            return 0;
                        }
                    }
                    //Check if the pocket is a score pocket
                    if (counter == 6)
                    {
                        //Add score if it is
                        scorePocket[turn]++;
                        i++;
                    }

                    //Else just add one to the next pocket
                    pocket[counter] = pocket[counter] + 1;



                    if (counter == 5)
                    {
                        //Check if user gets a new turn
                        if (i >= toMove)
                        {
                            return 1;
                        }
                    }


                }
            } else if(turn==1)
            {
                for (int i = 1; i <= toMove; i++)
                {
                    //move to the next pocket
                    counter++;
                    //Check if you can steal
                    if (counter < 12)
                    {
                        if (counter > 6)
                        {
                            if (i == toMove && pocket[counter] == 0)
                            {
                                calculator = getOpposite(counter);
                                scorePocket[1] = scorePocket[1] + pocket[calculator];
                                pocket[calculator] = 0;
                                pocket[counter] = 0;
                                return 0;
                            }
                        }
                    }
                    //Check if the pocket is a score pocket
                    if (counter == 12)
                    {
                        //Add score if it is
                        scorePocket[turn]++;
                        i++;
                    }

                    //Else just add one to the next pocket
                    pocket[counter] = pocket[counter] + 1;


                    //if the counter is more than the avialble pockets. reset to zero to loop around
                    if (counter >= 12)
                    {
                        //Check if user gets a new turn
                        if (i >= toMove)
                        { 
                            counter = -1;
                            return 1;
                        }

                        //This is after so the pieces can move before the counter gets reset
                        counter = -1;

                    }

                }
            }
            counter = 0;
            return 0;
        }
    }

}
