using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RES_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write number:");
            Calc calc1 = new Calc();
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, write operator:");
            string oper = Console.ReadLine();
            Console.WriteLine("Please, write number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (oper)
            {
                case "+":
             result = calc1.sum(firstNumber, secondNumber);
                    break;
                case "-":
             result = calc1.min(firstNumber, secondNumber);
                    break;
                case "*":
             result = calc1.mlt(firstNumber, secondNumber);
                    break;
                case "/":
             result = calc1.splt(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine(firstNumber + oper + secondNumber + '=' + result);
        }
    }
}
