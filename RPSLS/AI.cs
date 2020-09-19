using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Players
    {
        //member variables
        public List<string> names;
        //constructor
        public AI()
        {
            names = new List<string>();
            names.Add("Sheldon");
            names.Add("Penny");
            names.Add("Raj");
            names.Add("Stuart");
            names.Add("Will Wheaton");
            names.Add("Howard");
            names.Add("Amy Farrah Fowler");
            names.Add("Bernadette");
            names.Add("Priya");
            names.Add("Barry Kripke");
            type = "AI";
            RandomName();
        }
        //methods
        public override void ChooseGesture()
        {
            Random rand;
            rand = new Random();
            int listLength = gestures.Count;
            chosenGestureIndex = rand.Next(0,listLength -1);
            
        }
        public void RandomName()
        {
            Random rand;
            rand = new Random();
            int namesLength = names.Count;
            int nameIndex = rand.Next(0, namesLength - 1);
            playerName = names[nameIndex];
        }
    }
}
