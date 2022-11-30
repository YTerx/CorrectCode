using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectCodeClass
{
    public class ClassCorrect
    {
     
        public static bool IsCorrectCode(string candidate)
        {
            if (String.IsNullOrEmpty(candidate))
            {
                return false;
            }
            else
            { 
                return true;
            }
        }
        /*
        public static bool IsCorrectCode(string candidate)
        {
            if (candidate.Length < 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        */
    }
}
