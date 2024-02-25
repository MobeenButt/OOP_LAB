using StudentManagementSystem.DL;
using System;
using System.Collections.Generic;

namespace StudentManagementSystem.BL
{
    internal class Student_BL
    {
        public string name;
        public int age;
        public float FscMarks;
        public float EcatMarks;
        public float merit;

        public List<Subject_BL> Regsub;
        public DegreeProgram_BL regDegree;
        public List<DegreeProgram_BL> Preferences = new List<DegreeProgram_BL>();

        public Student_BL() { }
        public Student_BL(string name, int age, float fscMarks, float ecatMarks, List<DegreeProgram_BL> preferences)
        {
            this.name = name;
            this.age = age;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
            Preferences = preferences;
            Regsub = new List<Subject_BL>();
        }
     
        public float CalculateMerit()
        {
            return this.merit = (((FscMarks / 1100) * 0.45F) + ((EcatMarks / 400) * 0.55f)) * 100;
        }


        public bool REGSUBJECT(Subject_BL s)
        {
            int ch = CreditHours();
            if (Regsub != null && regDegree.ISsubjectExists(s) && ch + s.creditHours <= 9)
            {
                Regsub.Add(s);
                return true;

            }
            return false;
        }
        public int CreditHours()
        {
            int ch = 0;
            foreach (Subject_BL sub in Regsub)
            {
                ch = ch + sub.creditHours;
            }
            return ch;
        }
     

        public float CalFee()
        {
            float fee = 0;
            if (regDegree != null)

            {
                foreach (Subject_BL sub in Regsub)
                {
                    fee = fee + sub.subjectFee;
                }
            }
            return fee;
        }
        public static Student_BL AddStudent(List<DegreeProgram_BL> degree)
        {
            List<DegreeProgram_BL> PreferencesList = new List<DegreeProgram_BL>();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC Marks: ");
            float fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            float ecatMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Number of Preferences: ");
            int preference = int.Parse(Console.ReadLine());

            for (int i = 0; i < preference; i++)
            {
                Console.Write("Enter Preference {0}: ", i + 1);
                string pref = Console.ReadLine();
                DegreeProgram_BL preferredDegree = degree.Find(d => d.title == pref);

                if (preferredDegree != null && preferredDegree.seats > 0)
                {
                    PreferencesList.Add(preferredDegree);
                }
                else
                {
                    Console.WriteLine("No such Degree Program Available...");
                    Console.ReadLine();
                }
            }

            return new Student_BL(name, age, fscMarks, ecatMarks, PreferencesList);
        }
    }
}
