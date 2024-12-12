using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class Generics<T>
    {
        public Generics(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
