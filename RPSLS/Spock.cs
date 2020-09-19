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
        public override void GestureExplanation(Gestures gesture)
        {
            if (gesture.gestureName == "Scissors")
            {
                Console.WriteLine("Spock Smashes Scissors");
            }
            else if(gesture.gestureName == "Rock")
            {
                Console.WriteLine("Spock Vaporizes Rock");
            }
        }
    }
}
