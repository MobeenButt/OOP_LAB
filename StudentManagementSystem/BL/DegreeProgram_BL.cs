using StudentManagementSystem.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BL
{
    internal class DegreeProgram_BL
    {
        public string title;
        public float duration;
        public int seats;
      public   List<Subject_BL> subjects;
        public List<Subject_BL> degrees;
        public DegreeProgram_BL(string title, float duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject_BL>();
            degrees= new List<Subject_BL>();

        }
        public bool AddSubject(Subject_BL s)
        {
            int ch = CalCreditHours();
            if (s.creditHours + ch <= 20)
            {
                subjects.Add(s);
                Subject_DL.StoreSubjectsDATAtoFile(s, "Subject.txt");
                return true;
            }
            return false;
        }
        public int CalCreditHours()
        {
            int CH = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                CH = CH + subjects[i].creditHours;
            }
            return CH;
        }

        public bool ISsubjectExists(Subject_BL s)
        {
            foreach (Subject_BL subject in subjects)
            {
                if (subject.code == s.code)
                {
                    return true;
                }
            }
            return false;
        }


    }
}