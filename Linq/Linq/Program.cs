using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] data = { 78, 28, 74, 2, 10, 6, 7,45,16,15 };
            var mean = from v in data
                       orderby v
                       select v;

            //var avg = data.Take(5).Average();
            //var avg1 = data.Skip(5).Average();

            //Console.WriteLine("with take "+avg);
            //Console.WriteLine("with skip " + avg1);

            //var selectedData = from v in data
            //                   where v > avg && v > 6
            //                   select v;
            //foreach(var d in selectedData)
            //{
            //    Console.WriteLine(d);
            //}

            int[] data1 = { 10, 12, 32, 24, 5, 16, 7, 8};
           
            var finalData = data.Concat(data1).ToArray();
            var commonData = data.Intersect(data1).ToArray();
            var Uniondata = data.Union(data1).ToArray();

            foreach (var d in commonData)
            {
                Console.Write(d + " ");
            }
            Console.WriteLine();
            foreach (var d in finalData.OrderBy(d=>d))
            {
                Console.Write(d+" ");
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { Id = 1, Name = "abc", Age = 24, Description = "sports" });
            students.Add(new Student { Id = 2, Name = "xyz", Age = 21, Description = "dance" });
            students.Add(new Student { Id = 3, Name = "qwe", Age = 15, Description = "music" });
            students.Add(new Student { Id = 4, Name = "pqr", Age = 14, Description = "game" });
            students.Add(new Student { Id = 5, Name = "xyzw", Age = 29, Description = "nfjfwh" });


            //var selectData = from Student in students
            //                 where Student.Id < 3
            //                 select Student;

            //var selectData = from Student in students
            //                 where Student.Age < 30 && Student.Age>25
            //                 select Student;
            //var agearr = from Student in students
            //             select Student.Age;
            //var agearr = students.Select(a => a.Age);
            var agearr = students.Select<Student,float>(a => a.Age);
            //var agearr = students.Select<Student, String>(a => a.Age); //not give string value


            Console.WriteLine(agearr.Average());
            //var selectData = from Student in students
            //                 where Student.Age < agearr.Average()
            //                 select Student;

            var selectData = from Student in students
                             where Student.Name.Contains("x")
                             select Student;
            foreach (var d in selectData)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
