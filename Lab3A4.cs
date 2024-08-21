using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int MyDel(int num);
delegate void MyDelB();
delegate void MyDelC();
namespace Lab3_MAB
{
    internal class Lab3A4
    {
        static int Factorial(int num)
        {
            int fact = 1;
            for(int i=2; i<=num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public void Display()
        {
            int result = 0;
            int number = 0;

            MyDel d1 = new MyDel(Factorial);

            Console.WriteLine("Enter a number ==> ");
            number = Convert.ToInt32(Console.ReadLine());

            result = d1(number);

            Console.WriteLine("Factorial is ==> " + result);
        }

        public static void Yellow()
        {
            Console.WriteLine("Inside method Yellow...");
        }

        public static void Green()
        {
            Console.WriteLine("Inside method Green...");
        }

        public static void Red()
        {
            Console.WriteLine("Inside method Blue...");
        }

        public void DisplayB()
        {
            MyDelB b1 = new MyDelB(Yellow);
            MyDelB b2 = new MyDelB(Green);
            MyDelB b3 = new MyDelB(Red);
        }

        public void Calculate()
        {
            int result = 0;

            Console.WriteLine("Enter first number ==> ");
            int numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number ==> ");
            int numB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operation from:: + - / *");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                result = numA + numB;
                Console.WriteLine("Addition is ==> " + result);
            }
            else if (operation == "-")
            {
                result = numA - numB;
                Console.WriteLine("Substraction is ==> " + result);
            }
            else if (operation == "*")
            {
                result = numA * numB;
                Console.WriteLine("Multiplication is ==> " + result);
            }
            else
            {
                if (operation == "/" && numB != 0)
                {
                    result = numA / numB;
                    Console.WriteLine("Division is ==>" + result);
                }
                else
                {
                    Console.WriteLine("Number cannot be divided by zero...");
                }
            }
        }

        public void DisplayC()
        {
            MyDelC d1 = new MyDelC(Calculate);
        }
    }
}
