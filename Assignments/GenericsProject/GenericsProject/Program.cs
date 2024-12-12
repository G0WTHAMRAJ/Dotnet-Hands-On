using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics<string> gen = new Generics<string>("i am generic class");
            Generics<int> gen1 = new Generics<int>(1234);
            Generics<double> gen2 = new Generics<double>(1234.12344);
            Collections collect = new Collections();

            collect.Add();

            LinqDistinct linq= new LinqDistinct();
            linq.linqDistinct();

            Student student = new Student();
            student.studentData();
        }
    }
}
