using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class cleark : Role
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }

        public cleark()
        {
            Console.Write("Enter cleark ID: ");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter cleark name: ");
            this.Name = Console.ReadLine();
            
        }

        public void update(int id)
        {
            try
            {

                this.Id = id;
                Console.Write("Enter cleark name: ");
                this.Name = Console.ReadLine();
                
                //people.Add(new Student { Id = studentId, Name = studentName, Course = studentCourse });


            }
            catch
            {
                throw new NotImplementedException();

            }

        }


        public void PrintInfo()
        {
            Console.WriteLine($"Student - ID: {Id}, Name: {Name}");

           // throw new NotImplementedException();
        }
    }
}
