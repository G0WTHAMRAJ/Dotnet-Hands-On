using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Reference.Delegate;

namespace Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Add ; //out Parameter no need to initialize
            int Sub = 0; // ref parameter must be intialize
            int Multiply = 0;
            int quotient;
            int remainder;
            Math(91, 30, out Add, ref Sub, ref Multiply, out quotient,out remainder);
            Console.WriteLine($"Addition: {Add}");
            Console.WriteLine($"Subration:{Sub}");
            Console.WriteLine($"Multiplication:{Multiply}");
            Console.WriteLine($"Divide quotient:{quotient}");
            Console.WriteLine($"Divide Remaider:{remainder}");

         

            //Delegates 

            MathOperation operation;

            operation = addition;
            Console.WriteLine($"Addition: {operation(10, 20)}"); 

            operation = Multiplication;
            Console.WriteLine($"Multiplication: {operation(10, 20)}");

            Console.ReadLine();
        }


            public static void Math(int number1, int number2, out int Addition, ref int Subraction, ref int Multy, out int quotient,out int remainder) {
            Addition = number1 + number2;
            Subraction = number1 - number2;
            Multy = number1 * number2;
            quotient = number1 / number2;
            remainder = number1 % number2;
            }
        
        }
    }
