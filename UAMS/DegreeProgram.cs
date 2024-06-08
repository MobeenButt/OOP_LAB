using System;
using System.Collections.Generic;

namespace UAMS
{
    internal class DegreeProgram
    {
        public string title;
        public string duration;
        public List<Subject> subjects;
        public int seats;
        public DegreeProgram()
        {
            ///Empty Constructor
        }
        public DegreeProgram(string title, string duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            subjects = new List<Subject>();
            this.seats = seats;
        }

        public int CreditHours()
        {
            int creditHours = 0;
            for (int i = 1; i < subjects.Count; i++)
            {
                creditHours = creditHours + subjects[i].creditHours;
            }
            return creditHours;
        }

        public bool isSubjectExists(Subject sub)
        {
            foreach(Subject s in subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;

        }
        public void AddSubject(Subject s)
        {
            int CH = CreditHours();
            if (CH + s.creditHours <= 20)
            {
                subjects.Add(s);
            }
            else
            {
                Console.WriteLine("20 Credit Hours Limit Exceeded");
            }
        }
    }
}
