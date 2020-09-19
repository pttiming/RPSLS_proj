using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Gestures
    {
        //member variables
        public string gestureName;

        //constructor

        //methods
        public abstract bool GestureWins(Gestures gesture);
        public abstract void GestureExplanation(Gestures gesture);
    }
}
