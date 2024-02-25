using StudentManagementSystem.BL;
using System.Collections.Generic;
using System.IO;

namespace StudentManagementSystem.DL
{
    internal class Subject_DL
    {
        public static List<Subject_BL> Subject = new List<Subject_BL>();
        public static void AddSubjectInList(Subject_BL subject)
        {
            Subject.Add(subject);
        }
        //public static List<Subject_BL>AllSubjects=new List<Subject_BL>();

        public static Subject_BL IsSubjectExists(string sub)
        {
            foreach(Subject_BL subject in Subject)
            {
                if (subject.subjectType == sub)
                {
                    return subject;
                }
            }
            return null;
        }
      
     
        public static void StoreSubjectsDATAtoFile(Subject_BL s, string path)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(s.code + "," + s.subjectType + "," + s.creditHours + "," + s.subjectFee);
            writer.Flush();
            writer.Close();
        }
        public static bool READsubjectFromFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = streamReader.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string code = splittedRecord[0];
                    string subjectType = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2]);
                    float subjectFee = float.Parse(splittedRecord[3]);
                    Subject_BL s = new Subject_BL(code, creditHours, subjectType, subjectFee);
                    AddSubjectInList(s);
                }
                streamReader.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

