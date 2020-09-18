using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Spock : Gestures
    {
        //member variables

        //constructor
        public Spock()
        {
            gestureName = "Spock";
        }

        //methods
        public override bool GestureWins(Gestures gesture)
        {
            if (gesture.gestureName == "Scissors" || gesture.gestureName == "Rock")
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
