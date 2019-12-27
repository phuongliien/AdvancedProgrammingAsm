using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            int n = 0;
            List<Person> p = new List<Person>();
            Students std = new Students();
            Lecturers lec = new Lecturers();
            do
            {
                Console.WriteLine("******************** Student Management System ****************************");
                Console.WriteLine("*************** Menu *****************");
                Console.WriteLine("1. Manage Students.");
                Console.WriteLine("2. Manage Lecturers.");
                Console.WriteLine("3. Exit system!!");
                Console.WriteLine("-----------------------------------------------------------------------------------------------");
                Console.Write("Enter your choice: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("input a number");
                }
                bool repeat = false;
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        int c1 = 0;


                        do
                        {
                            Console.WriteLine("*************** Menu *****************");
                            Console.WriteLine("  1. Add new student.");
                            Console.WriteLine("  2. View all students.");
                            Console.WriteLine("  3. Search students.");
                            Console.WriteLine("  4. Delete students.");
                            Console.WriteLine("  5. Update student.");
                            Console.WriteLine("  6. Back to main menu.");
                            Console.WriteLine("-------------------------------------------------------------------------------------");
                            Console.Write("Enter your choice: ");
                            try
                            {
                                c1 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("input a number");
                            }


                            switch (c1)
                            {
                                case 1:
                                    std.AddStd(p);
                                    Console.Clear();
                                    break;
                                case 2:
                                    std.ViewAllStd(p);
                                    
                                    break;
                                case 3:
                                    std.PrintResult(p);
                                    
                                    break;
                                case 4:
                                    std.Delete(p);
                                    
                                    break;
                                case 5:
                                    std.Update(p);
                                    
                                    break;
                                case 6:

                                    Console.WriteLine("Go back to main menu? - * Press any other button.");
                                    ConsoleKeyInfo keyPressed;
                                    keyPressed = Console.ReadKey();
                                    if (keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.NumPad1)
                                    {
                                        repeat = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        repeat = false;
                                    }
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Invalid input!!");
                                    break;
                            }
                        } while (c1 != 6);

                        break;
                    case 2:
                        int c2 = 0;
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("*************** Menu *****************");
                            Console.WriteLine("1. Add new lecturer.");
                            Console.WriteLine("2. View all lecturers.");
                            Console.WriteLine("3. Search lecturers.");
                            Console.WriteLine("4. Delete lecturers.");
                            Console.WriteLine("5. Update lecturer.");
                            Console.WriteLine("6. Back to main menu.");
                            Console.WriteLine("--------------------------------------------------------------------------------------------");
                            Console.Write("Enter your choice: ");
                            try
                            {
                                c2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("input a number");
                            }
                            switch (c2)
                            {
                                case 1:
                                    lec.AddLec(p);
                                   
                                    break;
                                case 2:

                                    lec.ViewAllLEc(p);
                                    break;
                                case 3:
                                    lec.SearchLec(p);
                                    break;
                                case 4:
                                    lec.DeleteLec(p);
                                    break;
                                case 5:
                                    lec.UpdateLec(p);
                                    break;
                                case 6:

                                    Console.WriteLine("Go back to main menu? - Press any other button.");
                                    ConsoleKeyInfo keyPressed;
                                    keyPressed = Console.ReadKey();
                                    if (keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.NumPad1)
                                    {
                                        repeat = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        repeat = false;
                                    }
                                    Console.Clear();
                                    break;
                                    
                                default:
                                    Console.WriteLine("Invalid input!!");
                                    break;

                            }
                        } while (c2 != 6);

                        break;


                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid value");
                        break;
                }
            } while (choice != 3);
        }
    }
}
