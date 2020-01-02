using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Students: Person
    {
        public string StdBatch { get; set; }
        public Students() : base()
        {

        }
        public Students(string id, string name, DateTime dob, string email, string address, string batch) : base(id, name, dob, email, address)
        {
            this.StdBatch = batch;
        }
        public void AddStd(List<Person> std)
        {              
            Test t = new Test();

            while (true)
            {
                Console.Write("Enter Student ID: ");
                string id = Console.ReadLine();
                if (t.CheckFormIDStd(id) == 0)
                {
                    this.Id = id;
                    break;
                }
                else
                {
                    Console.WriteLine("Re-enter right form ID: ");
                }
            }
            base.Add();
            Console.Write("Enter Student batch: ");
            this.StdBatch = Console.ReadLine();
            std.Add(new Students(this.Id, this.Name, this.DoB, this.Email, this.Address, this.StdBatch));

        }
        public new void ViewAllStd(List<Person> std)
        {
            if (std.Count == 0)
            {
                Console.WriteLine("No data available!!!");
                return;
            }
            else
            {
                Console.WriteLine("ID     |Name    |Date of birth|     Email| Address| Batch ");
                Console.WriteLine("");
                foreach (Person c in std)
                {
                    Students s = c as Students;
                    Console.WriteLine(s.Id + " |" + s.Name + "  | " + s.DoB + "| " + s.Email + "| " + s.Address + "| " + s.StdBatch);
                }
            }
            
        }
        public void SearchStd(List<Person> std)
        {
            Console.WriteLine("Enter Student name you want to search:");
            string name = Console.ReadLine();

            base.PrintResult(std);
        }

        public void DeleteStd(List<Person> std)
        {
            if (std.Count == 0)
            {
                Console.WriteLine("No data available!!");
            }
            else
            {
                base.Delete(std);
            }
            
        }
        public void UpdateStd(List<Person> std)
        {
            if (std.Count == 0)
            {
                Console.WriteLine("No data available!!");
            }
            else
            {
                base.Update(std);
            }
        }
    }
}
