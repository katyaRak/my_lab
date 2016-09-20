using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES_lab_1
{
    public class Calc
    {
   
        public int sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int min(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;

        }
        public int mlt(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;

        }

        public int splt(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
                {
                  Console.WriteLine("Error, div by zero. Try again");
                }
            return firstNumber / secondNumber;

        }

       
    }
}
