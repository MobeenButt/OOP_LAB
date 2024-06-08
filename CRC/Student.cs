using System;
namespace CRC
{
     class Student
    {
        public string name;
        public int rollNumber;
        public float GPA;
        public int MatricMarks;
        public int FscMarks;
        public int EcatMarks;
        public string HomeTown;
        public bool isHostelite;
        public bool isTakeScholarship;

       public Student()
        {
            ////DEFAULT CONSTRUCTOR
        }
        public Student(string name, int rollNumber, float gPA, int matricMarks, int fscMarks, int ecatMarks, string homeTown, bool isHostelite, bool isTakeScholarship)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            GPA = gPA;
            MatricMarks = matricMarks;
            FscMarks = fscMarks;
            EcatMarks = ecatMarks;
            HomeTown = homeTown;
            this.isHostelite = isHostelite;
            this.isTakeScholarship = isTakeScholarship;
        }
        public float CalculateMerit()
        {
            float merit=(GPA*5)+MatricMarks+FscMarks+EcatMarks;
            return merit;
        }
        public bool IsEligibleForScholarship(float meritPercentage)
        {
            if (isTakeScholarship)
            {
                return false;
            }
            else { return meritPercentage >= 80;
            }
        }
    }
}
