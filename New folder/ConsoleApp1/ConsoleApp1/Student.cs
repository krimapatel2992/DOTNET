using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student :Role
    {
        public int Id { get; set; }
    public string Name { get; set; }
        public string Course { get; set; }
        
        public Student()
        {
            Console.Write("Enter student ID: ");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter student name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter student Course: ");
            this.Course = Console.ReadLine();
        }
       
        public void update(int id)
        {
            try
            {

                this.Id = id;
                Console.Write("Enter student name: ");
                this.Name = Console.ReadLine();
                Console.Write("Enter student Course: ");
                this.Course = Console.ReadLine();


            }
            catch
            {
                throw new NotImplementedException();

            }

        }
        

        public void PrintInfo()
    {
        Console.WriteLine($"Student - ID: {Id}, Name: {Name}, Course: {Course}");
    }
    }
}
