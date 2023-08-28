using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Role> people = new List<Role>();
            while (true)
            {
                start:
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Teacher");
                Console.WriteLine("3. Add Clerk");
                Console.WriteLine("4. Add Peon");
                Console.WriteLine("5. Print All People");
                Console.WriteLine("6. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        int s;
                        while (true)
                        {
                            Console.WriteLine("Select an option:");
                            Console.WriteLine("1. Insert");
                            Console.WriteLine("2. Update");
                            Console.WriteLine("3. Dalete");
                            Console.WriteLine("4. Retrive");

                            Console.WriteLine("5. Exit");
                            s = Convert.ToInt32(Console.ReadLine());

                            switch (s)
                            {

                                case 1:
                                    people.Add(new Student());
                                    break;
                                case 2:
                                    Console.WriteLine("Enter id for update");

                                    int id1 = Convert.ToInt32(Console.ReadLine());
                                    Student s1 = (Student)(from r in people
                                                           where r.Id == id1
                                                           select r).FirstOrDefault();
                                    s1.update(id1);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter id for delete");

                                    int id2 = Convert.ToInt32(Console.ReadLine());
                                    Student s2 = (Student)(from r in people
                                                           where r.Id == id2
                                                           select r).FirstOrDefault();
                                    people.Remove(s2);
                                    break;
                                case 4:
                                    foreach (var item in people)
                                    {
                                        item.PrintInfo();
                                    }
                                    break;
                                case 5:
                                    goto start;

                            }

                        }

                    // people.Add(new Student());



                    case 2:
                        int t;
                        while (true)
                        {
                            Console.WriteLine("Select an option:");
                            Console.WriteLine("1. Insert");
                            Console.WriteLine("2. Update");
                            Console.WriteLine("3. Dalete");
                            Console.WriteLine("4. Retrive");

                            Console.WriteLine("5. Exit");
                            t = Convert.ToInt32(Console.ReadLine());

                            switch (t)
                            {

                                case 1:
                                    people.Add(new Teacher());
                                    break;
                                case 2:
                                    Console.WriteLine("Enter id for update");

                                    int id1 = Convert.ToInt32(Console.ReadLine());
                                    Teacher t1 = (Teacher)(from r in people
                                                           where r.Id == id1
                                                           select r).FirstOrDefault();
                                    t1.update(id1);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter id for delete");

                                    int id2 = Convert.ToInt32(Console.ReadLine());
                                    Teacher t2 = (Teacher)(from r in people
                                                           where r.Id == id2
                                                           select r).FirstOrDefault();
                                    people.Remove(t2);
                                    break;
                                case 4:
                                    foreach (var item in people)
                                    {
                                        item.PrintInfo();
                                    }
                                    break;
                                case 5:
                                    goto start;
                            }

                        } 
                        break;
                

                    
                      case 3:
                        int c;
                while (true)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Update");
                    Console.WriteLine("3. Dalete");
                    Console.WriteLine("4. Retrive");

                    Console.WriteLine("5. Exit");
                    c = Convert.ToInt32(Console.ReadLine());

                    switch (c)
                    {

                        case 1:
                            people.Add(new cleark());
                            break;
                        case 2:
                            Console.WriteLine("Enter id for update");

                            int id1 = Convert.ToInt32(Console.ReadLine());
                            cleark t1 = (cleark)(from r in people
                                                   where r.Id == id1
                                                   select r).FirstOrDefault();
                            t1.update(id1);
                            break;
                        case 3:
                            Console.WriteLine("Enter id for delete");

                            int id2 = Convert.ToInt32(Console.ReadLine());
                            cleark t2 = (cleark)(from r in people
                                                   where r.Id == id2
                                                   select r).FirstOrDefault();
                            people.Remove(t2);
                            break;
                        case 4:
                            foreach (var item in people)
                            {
                                item.PrintInfo();
                            }
                            break;
                        case 5:
                            goto start;
                    }

                }
            break;

                case 4:
                        int p;
                while (true)
                {
                    Console.WriteLine("Select an option:");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Update");
                    Console.WriteLine("3. Dalete");
                    Console.WriteLine("4. Retrive");

                    Console.WriteLine("5. Exit");
                    p = Convert.ToInt32(Console.ReadLine());

                    switch (p)
                    {

                        case 1:
                            people.Add(new pune());
                            break;
                        case 2:
                            Console.WriteLine("Enter id for update");

                            int id1 = Convert.ToInt32(Console.ReadLine());
                            pune t1 = (pune)(from r in people
                                                 where r.Id == id1
                                                 select r).FirstOrDefault();
                            t1.update(id1);
                            break;
                        case 3:
                            Console.WriteLine("Enter id for delete");

                            int id2 = Convert.ToInt32(Console.ReadLine());
                            pune t2 = (pune)(from r in people
                                                 where r.Id == id2
                                                 select r).FirstOrDefault();
                            people.Remove(t2);
                            break;
                        case 4:
                            foreach (var item in people)
                            {
                                item.PrintInfo();
                            }
                            break;
                        case 5:
                            goto start;
                    }

                }
                break;
            }
                }
            }



           



        }
        }


