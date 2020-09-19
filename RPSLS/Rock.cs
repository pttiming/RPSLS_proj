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
        public override void GestureExplanation(Gestures gesture)
        {
            if (gesture.gestureName == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors");
            }
            else if (gesture.gestureName == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard");
            }
        }
    }
}
