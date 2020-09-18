using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Rock : Gestures
    {
        //member variables

        //constructor
        public Rock()
        {
            gestureName = "Rock";
        }

        //methods
        public override bool GestureWins(Gestures gesture)
        {
            if (gesture.gestureName == "Scissors" || gesture.gestureName == "Lizard")
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
