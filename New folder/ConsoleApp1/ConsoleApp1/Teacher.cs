using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Teacher : Role
    {
        public int Id { get ; set; }
        public string Name { get  ; set  ; }
        public string Subject { get; set ; }

        public Teacher()
        {
            Console.Write("Enter teacher ID: ");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter teacher name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter teacher subject: ");
            this.Subject = Console.ReadLine();
        }
      

        public void update(int id)
        {
            try
            {

                this.Id = id;
                Console.Write("Enter teacher name: ");
                this.Name = Console.ReadLine();
                Console.Write("Enter teacher subject: ");
                this.Subject = Console.ReadLine();
                //people.Add(new teacher { Id = teacherId, Name = teacherName, Course = teacherCourse });


            }
            catch
            {
                throw new NotImplementedException();

            }

        }


        public void PrintInfo()
        {
            Console.WriteLine($"teacher - ID: {Id}, Name: {Name}, Subject: {Subject}");
        }
    }
}
