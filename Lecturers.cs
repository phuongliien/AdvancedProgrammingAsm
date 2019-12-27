using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Lecturers : Person
    {
        public string LecDept { get; set; }
        public Lecturers()
        {

        }
        public Lecturers(string id, string name, DateTime dob, string email, string address, string dept) : base(id, name, dob, email, address)
        {
            this.LecDept = dept;
        }
        public void AddStd(List<Person> std)
        {
            Test t = new Test();

            while (true)
            {
                Console.WriteLine("Enter Student ID: ");
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
            string b = Console.ReadLine();
            std.Add(new Students(this.Id, this.Name, this.DoB, this.Email, this.Address, this.LecDept));

        }
        public new void ViewAllLEc(List<Person> lec)
        {
            if (lec.Count == 0)
            {
                Console.WriteLine("No data available!!!");
                return;
            }
            else
            {
                Console.WriteLine("ID      |   Name |   Date of birth    |     Email     |Address|   Department ");
                foreach (Person c in lec)
                {
                    Lecturers lecture = c as Lecturers;
                    Console.WriteLine(lecture.Id + " | " + lecture.Name + "  | " + lecture.DoB + "| " + lecture.Email + "| " + lecture.Address + "| " + lecture.LecDept);
                }
            }

        }
        public void SearchLec(List<Person> lec)
        {
            if (lec.Count == 0)
            {
                Console.WriteLine("No data available!!");
            }
            else
            {
                Console.WriteLine("Enter Student name you want to search:");
                string name = Console.ReadLine();

                base.PrintResult(lec);
            }
            
        }

        public void DeleteLec(List<Person> lec)
        {
            if (lec.Count == 0)
            {
                Console.WriteLine("No data available!!");
            }
            else
            {
                base.Delete(lec);
            }

        }
        public void UpdateLec(List<Person> lec)
        {
            if (lec.Count == 0)
            {
                Console.WriteLine("No data available!!");
            }
            else
            {
                base.Update(lec);
            }
        }
    }
}
