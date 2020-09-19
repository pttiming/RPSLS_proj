using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Paper : Gestures
    {
        //member variables

        //constructor
        public Paper()
        {
            gestureName = "Paper";
        }

        //methods
        public override bool GestureWins(Gestures gesture)
        {
            if (gesture.gestureName == "Rock" || gesture.gestureName == "Spock")
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
            if (gesture.gestureName == "Rock")
            {
                Console.WriteLine("Paper covers Rock");
            }
            else if (gesture.gestureName == "Spock")
            {
                Console.WriteLine("Paper disproves Spock");
            }
        }
    }
}
