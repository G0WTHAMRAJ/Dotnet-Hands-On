using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    internal class Delegate
    {
        public delegate int MathOperation(int x, int y);

        public static int addition(int a, int b)
        {
            return a+b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
