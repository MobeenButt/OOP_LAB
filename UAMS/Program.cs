using System;
using System.Collections.Generic;
using System.Linq;

namespace UAMS
{
    internal class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<Student> sortedStudentList = new List<Student>();
        static List<DegreeProgram> programList = new
        List<DegreeProgram>();

        static void Main(string[] args)
        {

            int option;
            do
            {
                option = Menu();
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addIntoStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);
                }
                else if (option == 3)
                {
                    sortStudentsByMerit();
                    giveAdmission();
                    printStudents();
                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.Write("Enter Degree Name: ");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the Student Name: ");
                    string name = Console.ReadLine();
                    Student s = StudentPresent(name);
                    if (s != null)
                    {
                        viewSubjects(s);
                        registerSubjects(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFee();
                }
                clearScreen();
            }
            while (option != 8);
            Console.ReadKey();
        }

        static void clearScreen()
        {
            Console.Clear();
        }
        static int Menu()
        {
            int op = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.WriteLine("\t\t\tUAMS\n");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Add Degree Program");
                Console.WriteLine("3.Generate Merit");
                Console.WriteLine("4.View Registered Students");
                Console.WriteLine("5.View Students of a Specific Student");
                Console.WriteLine("6.Register Subjects for a Specific Student");
                Console.WriteLine("7.Calculate Fees for all Registered Students");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Enter Option...");

                string input = Console.ReadLine();

                if (op > 0 && op <= 8)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please try again.");
                    Console.ReadLine(); // Wait for user to press Enter
                    Console.Clear(); // Clear the console
                }
            }

            return op;
        }
        static void takeInputForDegree()
        {
            Console.WriteLine("Enter Degree Name: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter How many Subjects to Enter: ");
            int nSubjects = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Code: ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Type: ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours: ");
            int creditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fees: ");
            int Subjectfee = int.Parse(Console.ReadLine());
            Console.WriteLine("Press any key to Continue...");
            Console.ReadLine();
        }
        static void calculateFee()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " has" + s.CalculateFee() + " fees.");
                }
            }
        }
        static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter the Subject Code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub) {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;

                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    i--;
                }
            }
        }
        static List<Student> sortStudentsByMerit()
        {
            List<Student> sortedList=new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedList=studentList.OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }
        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }
    }
}