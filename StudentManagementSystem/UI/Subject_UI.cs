using StudentManagementSystem.BL;
using System;

namespace StudentManagementSystem.UI
{
    internal class Subject_UI
    {
        public static Subject_BL TakeInput()
        {
            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();
            Console.Write("Enter Subject Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter Subject Credit Hours: ");
            int CreditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject Fees: ");
            float fee = float.Parse(Console.ReadLine());
            Subject_BL subject = new Subject_BL(code, CreditHours, type, fee);
            return subject;
        }
        public static void REGSUB(Student_BL stu)
        {
            Console.WriteLine("Enter How many Subjects you want to Register:  ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Subject Code: ");
                string c = Console.ReadLine();
                bool validSubject = false;
                foreach (Subject_BL s in stu.regDegree.subjects)
                {
                    if (c == s.code && !(stu.Regsub.Contains(s)))
                    {
                        stu.REGSUBJECT(s);
                        validSubject = true;
                        break;
                    }
                }
                if (!validSubject)
                {
                    Console.WriteLine("No Such Course Exists...");
                    i = i - 1;
                }
            }
        }
        public static void ViewSUBJECT(Student_BL stu)
        {
            if (stu.regDegree != null)
            {
                Console.WriteLine("CODE \t\t TYPE\n");
                foreach (Subject_BL s in stu.regDegree.subjects)
                {
                    Console.WriteLine(s.code + " \t\t\t" + s.subjectType);

                }
            }
        }

    }

}
