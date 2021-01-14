using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentProjCalc
{
    public class MathUtils
    {
        // This method returns true if the input number is even.
        // Otherwise (for odd number)- it returns false;
        public bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // This method returns true if the input number is odd.
        // Otherwise (for even number)- it returns false;
        public bool IsOdd(int a)
        {
            if (a % 2 != 0)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        // The following method returns true if the input number is a prime number
        public bool IsPrime(int a)
        {
            int index;
            bool result = true;

            if (a > 0)
            {
                for (index = 2; index <= a - 1; index++)
                {
                    if (a % index == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            else
            {
                result = false;
            }

            return result;


        }



    }
}
