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
        int totalPeebles = 48;

        int peeblePerCup = 4;   

        //Fills the cup with the peebles per cup as indicated by the limits avobe
        public string fillCup()
        {
            return peeblePerCup.ToString();
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
        
    }

}
