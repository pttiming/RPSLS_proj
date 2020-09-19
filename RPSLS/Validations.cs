using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class Validations
    {
        public static void ValidateInteger()
        {

        }

        public static bool IsInteger(string input)
        {
            int response;
            if (int.TryParse(input, out response))
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


