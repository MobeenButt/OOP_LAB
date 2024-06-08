using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram>Applies;
        public List<Subject> regSubject;
        public DegreeProgram regDegree;
        
        public Student()
        {
            ///Empty CONSTRUCTORS
        }
        public Student(string name,int age,double fscMarks,double ecatMarks, List<DegreeProgram> Applies)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
          
        }
        public bool regstudentSubject(Subject s)
        {
            int cH = getCreditHours();
            if(regDegree==null && regDegree.isSubjectExists(s)&& cH+s.creditHours<=9)
            {
                regSubject.Add(s);
                return true;
            }
            return false;
        }
        public double calculateMerit()
        {
            merit = fscMarks * ecatMarks/40;
            return merit;
        }
        public int getCreditHours()
        {
            int creditHours = 0;
        for(int i = 1;i< regSubject.Count; i++)
            {
                creditHours = creditHours + i;
            }
            return creditHours;
        }


        public double CalculateFee()
        {
            double fee = 0;
           foreach(Subject subject in regSubject)
            {
                fee = fee + subject.Subjectfee;
            }
            return fee;
        }
        public bool regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null && regDegree.isSubjectExists(s) && stCH + s.creditHours <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
