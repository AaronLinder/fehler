using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursionen
{
    public class Rekursion
    {
        public static int Fakultaet(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            if(number == -1) { 
                return -1; 
            }
            if(number < 0)
            {
                return Fakultaet(number + 1) * number;
            }
            return Fakultaet(number -1)* number;
        }

        public static int Fibunacci(int number)
        {
            if (number <= 0)
            {
                return 0;
            }
            if (number == 1)
            {
                return 1;
            }
            return Fibunacci(number -1) + Fibunacci(number - 2);
        }
    }
}
