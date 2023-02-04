using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class calculator
    {
        int number1;
        int number2;

        public void takeinput()
        {
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
        }


        public double add(int number1, int number2)
        { 
            return number1+number2; 
        }

        public double subtract(int number1, int number2) 
        { 
            if(number1>number2)
            {
                return number1 - number2;
            }
            return number2-number1; 
        }

        public double multiply(int number1, int number2) 
        { 
            return number1* number2;
        }

        public double divide(int number1, int number2)
        {
            if (number1 == 0)
            {
                Console.WriteLine("ERROR: DIVISION BY ZERO IS UNDEFINED");
                return 0;
            }
            if (number2 == 0)
            {
                Console.WriteLine("ERROR: DIVISION BY ZERO IS UNDEFINED");
                return 0;
            }
            else
            {
                return number1 / number2;
            }
        }

        static void Main(string[] args)
        {
            calculator c = new calculator();

            Console.WriteLine("ENTER TWO INPUT");

            c.takeinput();

            Console.WriteLine("ADDITION");

            Console.WriteLine(c.add(c.number1, c.number2));

            Console.WriteLine("SUBTRACTION");

            Console.WriteLine(c.subtract(c.number1, c.number2));

            Console.WriteLine("MULTIPLICATION");

            Console.WriteLine(c.multiply(c.number1, c.number2));

            Console.WriteLine("DIVISION");

            Console.WriteLine(c.divide(c.number1, c.number2));

            Console.WriteLine("<3 THANKS FOR APPRICIATING MY CALCULATION POWER <3");

            Console.ReadLine();
        }
    }
}
