using StudentManagementSystem.BL;
using System.Collections.Generic;
using System.IO;

namespace StudentManagementSystem.DL
{
    internal class DegreeProgram_DL
    {
        public static List<DegreeProgram_BL> Degree = new List<DegreeProgram_BL>();
        public static void AddDegreeinList(DegreeProgram_BL degree)
        {
            Degree.Add(degree);
        }
        public static DegreeProgram_BL IsDegreeExists(string degName)
        {
            foreach (DegreeProgram_BL degree in Degree)
            {
                if (degree.title == degName)
                {
                    return degree;
                }
            }
            return null;
        }

        public static void StoreInFile(string path, DegreeProgram_BL degree)
        {
            StreamWriter write = new StreamWriter(path, true);
            string subName = "";
            for (int i = 0; i < degree.subjects.Count; i++)
            {
                subName = subName + degree.subjects[i].subjectType + ";";

            }
            subName = subName + degree.subjects[degree.subjects.Count - 1].subjectType;
            write.WriteLine(degree.title + "," + degree.duration + "," + degree.seats + "," + subName);
            write.Flush();
            write.Close();
        }

        public static bool ReadFromFile(string path)
        {
            StreamReader read = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = read.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string Degname = splittedRecord[0];
                    float degDuration = float.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    DegreeProgram_BL degree = new DegreeProgram_BL(Degname, degDuration, seats);
                    for (int i = 0; i < splittedRecord.Length; i++)
                    {
                        Subject_BL s = Subject_DL.IsSubjectExists(splittedRecord[i]);
                        if(s != null)
                        {
                            degree.AddSubject(s);
                        }
                    }
                    AddDegreeinList(degree);
                }
                read.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
