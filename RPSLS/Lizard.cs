using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Lizard : Gestures
    {
        //member variables

        //constructor
        public Lizard()
        {
            gestureName = "Lizard";
        }

        //methods
        public override bool GestureWins(Gestures gesture)
        {
            if (gesture.gestureName == "Paper" || gesture.gestureName == "Spock")
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
            if (gesture.gestureName == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock");
            }
            else if (gesture.gestureName == "Paper")
            {
                Console.WriteLine("Lizard eats Paper");
            }
        }
    }

}
