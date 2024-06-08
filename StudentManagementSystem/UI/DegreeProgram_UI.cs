using StudentManagementSystem.BL;
using StudentManagementSystem.DL;
using System;
using System.Collections.Generic;

namespace StudentManagementSystem.UI
{
    
    internal class DegreeProgram_UI
    {
        //static List<DegreeProgram_BL> degreeProgramList = new List<DegreeProgram_BL>();
        public static void ViewDegree()
        {
            foreach (DegreeProgram_BL degree in DegreeProgram_DL.Degree)
            {
                Console.WriteLine(degree.title);
            }
}
public static DegreeProgram_BL TakeInputToAddDegree()
        {
            Console.Write("Enter Degree Name: ");
            string title = Console.ReadLine();
            Console.Write("Enter Degree Duration: ");
            float duration = float.Parse(Console.ReadLine());
            Console.Write("Enter Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());
            DegreeProgram_BL degree = new DegreeProgram_BL(title, duration, seats);
           
            Console.Write("How many Subjects you want to add in Degree: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Subject_BL s = Subject_UI.TakeInput();
                if (degree.AddSubject(s))
                {
                    if (Subject_DL.Subject.Contains(s))
                    {
                        Subject_DL.AddSubjectInList(s);
                        Subject_DL.StoreSubjectsDATAtoFile(s,"subject.txt");


                    }
                    Console.WriteLine("Subject Added!");
                }
                else
                {
                    Console.WriteLine("20 Credit Hours limit Exceede!");
                }
            }
            return degree;
        }

        public static string TakeDegree()
        {
            string DegreeName;
            Console.Write("Enter Degree Name: ");
            DegreeName = Console.ReadLine();
            return DegreeName;
        }
    }
}