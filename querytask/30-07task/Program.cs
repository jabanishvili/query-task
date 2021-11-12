using System;
using System.Linq;
using System.Collections.Generic;
namespace _30_07task
{
    public class Student
    {
        string Name { get; set; }
        string LastName { get; set; }
        int Age { get; set; }

        public override string ToString()
        {
            return $"name {Name} lastname {LastName} age {Age}";
        }



        class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>
          {
              new Student { Name= "ani", LastName ="jbna", Age=22},
              new Student { Name= "akaki", LastName ="shukakidze", Age=19},
              new Student { Name= "iveri", LastName ="mamasaxlisovi", Age=22},
              new Student { Name= "dato", LastName ="ugulava", Age=29},
              new Student { Name= "archil", LastName ="gorgadze", Age=24},
          };
                var query = from i in students
                            group i by i.Age
                           into f
                            orderby f.Key
                            select f;
                foreach (var group in query)
                {
                    Console.WriteLine(group.Key+ "" );
                    foreach (var item in group)
                    {
                        Console.WriteLine(item.Age);
                    }
                }
            }
        }
    }
}