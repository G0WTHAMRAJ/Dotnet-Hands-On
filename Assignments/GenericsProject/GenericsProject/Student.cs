using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    internal class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age {  get; set; }

        public void studentData()
        {

            IList<Student> studentList = new List<Student>()
            {
                new Student() { Id = 1, Name = "Gowtham", Age = 23 },
                new Student() { Id = 2, Name = "Nivy", Age = 24 },
                new Student() { Id = 3, Name = "Jai", Age = 23 },                
                new Student() { Id = 3, Name = "Akash", Age = 24 },
            };

            var thenByResult = studentList.OrderBy(s => s.Name).ThenBy(s => s.Age);
            var thenByDescResult = studentList.OrderBy(s => s.Age).ThenBy(s => s.Name);
            studentList.OrderBy(s => s.Name).ThenBy(s => s.Age);
            foreach (Student student in thenByResult)
            {
                Console.WriteLine($" Name : {student.Name}  Age :{student.Age}");
            }
            Console.WriteLine("decending ");
            foreach (Student student in thenByDescResult)
            {
                Console.WriteLine($"Name  :  {student.Name}  Age : {student.Age}");
            }

        }

    }
}
