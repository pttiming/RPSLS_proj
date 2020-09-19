using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scissors : Gestures
    {
        //member variables

        //constructor
        public Scissors()
        {
            gestureName = "Scissors";
        }

        //methods
        public override bool GestureWins(Gestures gesture)
        {
            if (gesture.gestureName == "Paper" || gesture.gestureName == "Lizard")
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
            if (gesture.gestureName == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper");
            }
            else if (gesture.gestureName == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard");
            }
        }
    }

}
