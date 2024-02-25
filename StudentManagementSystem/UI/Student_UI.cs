using StudentManagementSystem.BL;
using StudentManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem.UI
{
    internal class Student_UI
    {
        //static  List<DegreeProgram_BL> degree;
        public static Student_BL TakeInputToAddStudent()
        {
            List<DegreeProgram_BL> PreferencesList = new List<DegreeProgram_BL>();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            // Validate and parse age input
            int age;
            while (true)
            {
                Console.Write("Enter Student Age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break; // Exit the loop if parsing succeeds
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                }
            }

            // Validate and parse fsc marks input
            float fsc;
            while (true)
            {
                Console.Write("Enter Student Fsc Marks: ");
                if (float.TryParse(Console.ReadLine(), out fsc))
                {
                    break; // Exit the loop if parsing succeeds
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid floating-point number for Fsc Marks.");
                }
            }

            // Validate and parse ecat marks input
            float ecat;
            while (true)
            {
                Console.Write("Enter Student Ecat Marks: ");
                if (float.TryParse(Console.ReadLine(), out ecat))
                {
                    break; // Exit the loop if parsing succeeds
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid floating-point number for Ecat Marks.");
                }
            }

            Console.WriteLine("Available Degree Programs: ");
            DegreeProgram_UI.ViewDegree();

            int preference;
            while (true)
            {
                // Validate and parse preference input
                Console.Write("Enter Number of Preferences: ");
                if (int.TryParse(Console.ReadLine(), out preference))
                {
                    break; // Exit the loop if parsing succeeds
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for number of preferences.");
                }
            }

            // Loop through each preference and add to PreferencesList if it's valid
            for (int i = 0; i < preference; i++)
            {
                string degname;
                do
                {
                    Console.Write("Enter Degree Program Name for Preference " + (i + 1) + ": ");
                    degname = Console.ReadLine();
                    if (PreferencesList.Any(d => d.title == degname))
                    {
                        Console.WriteLine("This degree program is already selected. Please choose a different one.");
                    }
                    else if (!DegreeProgram_DL.Degree.Any(d => d.title == degname))
                    {
                        Console.WriteLine("Invalid degree program name. Please enter a valid one.");
                    }
                    else
                    {
                        // Find the DegreeProgram_BL object and add it to the list
                        DegreeProgram_BL degree = DegreeProgram_DL.Degree.First(d => d.title == degname);
                        PreferencesList.Add(degree);
                        break; // Exit the loop if a valid degree program is found and added
                    }
                } while (true);
            }

            // Create the Student_BL object with the collected information
            Student_BL stu = new Student_BL(name, age, fsc, ecat, PreferencesList);
            return stu;
        }

        public static void DisplayStudents()
        {
            foreach (Student_BL stu in Student_DL.Student)
            {
                if (stu.regDegree != null)
                {
                    Console.WriteLine("{0} got Admission in {1}.", stu.name, stu.regDegree.title);
                }
                else
                {
                    Console.WriteLine("{0} did not get Admission", stu.name);
                }
            }
        }

        public static void ViewREGSTUDENTS()
        {
            Console.WriteLine("Name\t\tFSC\t\tECAT\t\tAGE");
            foreach (Student_BL stu in Student_DL.Student)
            {
                if (stu.regDegree != null)
                {
                    Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-5}", stu.name, stu.FscMarks, stu.EcatMarks, stu.age);
                }
            }
        }
        public static void CalFee()
        {
            foreach (Student_BL stu in Student_DL.Student)
            {
                if (stu.regDegree != null)
                {
                    Console.WriteLine("{0} has {1} Fees.", stu.name, stu.CalculateMerit());
                }
            }
        }
        public static void ViewStuDegree(string deg)
        {
            Console.WriteLine("Name\t\tFSC\t\tECAT\t\tAGE");
            foreach (Student_BL stu in Student_DL.Student)
            {
                if (stu.regDegree != null && deg == stu.regDegree.title)
                {
                    Console.WriteLine("{0,-20}\t{1,-10}\t{2,-10}\t{3,-5}", stu.name, stu.FscMarks, stu.EcatMarks, stu.age);
                }
            }
        }
        //    public static string TAKEName()
        //    {
        //        Console.WriteLine("Enter Student Name: ");
        //        string name = Console.ReadLine();
        //        return name;
        //    }

        //    internal static Student_BL AddStudent(bool v)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}