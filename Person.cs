using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        List<Person> p = new List<Person>();
        public Person()
        {

        }

        public Person(string id, string name, DateTime dob, string email, string address)
        {
            this.Id = id;
            this.Name = name;
            this.DoB = dob;
            this.Email = email;
            this.Address = address;

        }
        
        public virtual void Add()
        {
            
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine();
           
            Console.Write("Enter Date of birth: ");
            this.DoB = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter Email: ");
            string email1 = Console.ReadLine();
            string mailformat = "@gmail.com";
            if (email1.Contains(mailformat))
            {
                this.Email = email1;
            }
            else
            {
                Console.WriteLine("Wrong email format, please re-enter!!");
            }

            Console.Write("Enter Address: ");
            this.Address = Console.ReadLine();
        }
        public virtual void View(List<Person> p)
        {
            if (p == null)
            {
                Console.WriteLine("No data available");
                return;
            }
            else
            {
                foreach (Person per in p)
                {
                    Console.WriteLine(per.Id + "| " + per.Name + "| " + per.DoB + "| " + per.Email + "| " + per.Address + "| ");
                }
            }
        }
        public virtual int SearchByName(List<Person> p)
        {
            Console.Write("Enter name of whom you want to search: ");
            string key = Console.ReadLine();
            int result = 0;
            foreach( Person per in p)
            {
                if (per.Name.Contains(key))
                {
                    result = p.IndexOf(per);
                }
            }
            return result;
        }
        
        public void PrintResult(List<Person> p)
        {
            int a = SearchByName(p);
            if (a != 0)
            {
                Console.WriteLine("Have no information");
            }
            else
            {
                    Console.WriteLine(p[a].Id + "| " + p[a].Name + "| " + p[a].DoB + "| " + p[a].Email + "| " + p[a].Address + "| ");
                
                
            }
        }
        public virtual void Delete(List<Person> p)
        {
            Console.Write("Enter the ID of whom you want to delete:");
            string key = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < p.Count; i++)
            {
                Person per = p[i];
                if (per.Id == key)
                {
                    result = p.IndexOf(per);
                    if (result > -1)
                    {
                        p.RemoveAt(result);
                        Console.WriteLine("Deleted!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Canceled!!!");
                    }
                }
                else
                {
                    Console.WriteLine("The ID doesn't exist!!!");
                }
            }

        }
        public static string InputOldValue(string sold, string snew)
        {
            if (snew == "")
            {
                return sold;
            }
            else
            {
                return snew;
            }
        }
        public static DateTime InputOldValueDoB(DateTime dold, string dnew)
        {
            if (dnew == "")
            {
                return dold;
            }
            else
            {
                return Convert.ToDateTime(dnew);
            }
        }
        public virtual void Update(List<Person> p)
        {
            
                Console.Write("Enter the  ID of whom you want to update: ");
                string id = Console.ReadLine();
                int result = 0;
                foreach (Person per in p)
                {
                    if (per.Id == id)
                    {
                        result = p.IndexOf(per);
                        if (result > -1)
                        {
                            Console.WriteLine("Now you can edit the information of this ID: " + this.Id);
                            Console.WriteLine("Edit what you want!");
                            Console.WriteLine("Student name: " + per.Name);
                            per.Name = Person.InputOldValue(per.Name, Console.ReadLine());
                            Console.WriteLine("Student date of birth: " + per.DoB);
                            per.DoB = Person.InputOldValueDoB(per.DoB, Console.ReadLine());
                            Console.WriteLine("Student name: " + per.Email);
                            per.Email = Person.InputOldValue(per.Email, Console.ReadLine());
                            Console.WriteLine("Student name: " + per.Address);
                            per.Address = Person.InputOldValue(per.Address, Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("No data available!!!");
                        }
                    }
                }
            }

        }
    }
    



