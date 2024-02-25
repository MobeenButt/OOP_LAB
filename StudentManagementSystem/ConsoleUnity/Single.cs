using StudentManagementSystem.BL;
using StudentManagementSystem.DL;
using StudentManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace StudentManagementSystem
{
    internal class Single
    {
      static  string subjectPath = "subject.txt";
      static  string degreePath = "degree.txt";
      static  string studentPath = "student.txt";
        public static int Menu()
        {
            int option;
            do
            {
                Subject_DL.READsubjectFromFile(subjectPath);
                Student_DL.ReadFromFile(studentPath);
                DegreeProgram_DL.ReadFromFile(degreePath);
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Degree Program");
                Console.WriteLine("3. Generate Merit");
                Console.WriteLine("4. View Registered Students");
                Console.WriteLine("5. View Students of a Specific Student");
                Console.WriteLine("6. Register Subjects for a Specific Student");
                Console.WriteLine("7. Calculate Fees for all Registered Students");
                Console.WriteLine("8. Exit");
                Console.Write("Enter Option: ");
                if (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 8)
                {
                    Console.WriteLine("Invalid option! Please enter a number between 1 and 8.");
                }
            } while (option < 1 || option > 8);

            return option;
        }

        public static void CLEAR()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        static void Files()
        {
         
            if (Student_DL.ReadFromFile(studentPath))
            {
                Console.WriteLine("Student Data Loaded Successfully!");

            }
            if (DegreeProgram_DL.ReadFromFile(degreePath))
            {
                Console.WriteLine("Degree Data Loaded Suceessfully!");
            }
            if (Subject_DL.READsubjectFromFile(subjectPath))
            {
                Console.WriteLine("Subject Data Loaded Sucessfully!");
            }
        }

        public static void Display()
        {
            Files();
            Thread.Sleep(100);
            CLEAR();
          
            int op = 0;
            do
            {
                op = Menu();
             
                if (op == 1)
                {
                    if (DegreeProgram_DL.Degree.Count > 0)
                    {
                        Student_BL stu = Student_UI.TakeInputToAddStudent();
                        Student_DL.AddStudentinList(stu);
                        Student_DL.StoreInFile(studentPath, stu);
                        
                    }
                    else
                    {
                        Console.WriteLine("Please add a degree program first.");
                    }
                }
                else if (op == 2)
                {
                    DegreeProgram_BL degree = DegreeProgram_UI.TakeInputToAddDegree();
                    DegreeProgram_DL.AddDegreeinList(degree);
                    DegreeProgram_DL.StoreInFile(degreePath, degree);
                   
                }
                else if (op == 3)
                {
                    List<Student_BL> sort = Student_DL.SORTSTUDENTS();
                   Student_DL.Admission(sort);
                    Student_UI.DisplayStudents();
                }
                else if (op == 4)
                {
                    Student_UI.ViewREGSTUDENTS();
                }
                else if (op == 5)
                {
                    string degreeName;
                    Console.Write("Enter Degree Name: ");
                    degreeName = Console.ReadLine();
                    Student_UI.ViewStuDegree(degreeName);
                   
                }
                else if (op == 6)
                {
                    string studentName;
                    Console.Write("Enter Student Name: ");
                    studentName = Console.ReadLine();
                    Student_BL s=Student_DL.Present(studentName);
                    if (s != null)
                    {
                        Subject_UI.ViewSUBJECT(s);
                        Subject_UI.REGSUB(s);
                    }

                }
                else if (op == 7)
                {
                    Student_UI.CalFee();
                }
                else if (op == 8)
                {
                    Console.WriteLine("Exiting...");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 8.");
                }
                CLEAR();
            } while (op != 8);
        }
    }
}
