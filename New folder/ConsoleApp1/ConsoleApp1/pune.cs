using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class pune : Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public pune()
        {
            Console.Write("Enter pune ID: ");
            this.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter pune name: ");
            this.Name = Console.ReadLine();

        }

        public void update(int id)
        {
            try
            {

                this.Id = id;
                Console.Write("Enter pune name: ");
                this.Name = Console.ReadLine();

             


            }
            catch
            {
                throw new NotImplementedException();

            }

        }


        public void PrintInfo()
        {
            Console.WriteLine($"Pune - ID: {Id}, Name: {Name}");

            // throw new NotImplementedException();
        }

    }
}
