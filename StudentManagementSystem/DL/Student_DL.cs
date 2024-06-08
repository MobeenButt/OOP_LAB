using StudentManagementSystem.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DL
{
    internal class Student_DL
    {
        public static List<Student_BL> Student = new List<Student_BL>();
        public static void AddStudentinList(Student_BL student)
        {
            Student.Add(student);
        }
        public static Student_BL Present(string name)
        {
            foreach (Student_BL stu in Student)
            {
                if (name == stu.name && stu.regDegree != null)
                {
                    return stu;
                }
            }
            return null;
        }
        public static void Admission(List<Student_BL> stu)
        {
            foreach (Student_BL s in stu)
            {
                foreach (DegreeProgram_BL degree in s.Preferences)
                {
                    if (degree.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = degree;
                        degree.seats = degree.seats - 1;
                        break;
                    }
                }
            }

        }
        public static List<Student_BL> SORTSTUDENTS()
        {
            List<Student_BL> sort = Student.OrderByDescending(o => o.CalculateMerit()).ToList();
            return sort;
        }

        public static void StoreInFile(string path, Student_BL s)
        {
            StreamWriter r = new StreamWriter(path);
            foreach (Student_BL stu in Student)
            {
                string preferences = string.Join(";", stu.Preferences.Select(o => o.title));
                r.WriteLine($"{stu.name},{ stu.age}, {stu.FscMarks},{ stu.EcatMarks},{ preferences}");
            }
            r.Flush();
            r.Close();
            //StreamWriter writer=new StreamWriter(path,true);
            // string degName = "";
            // for(int i = 0; i < s.Preferences.Count; i++)
            // {
            //     degName = degName + s.Preferences[i].title + ";";

            // }
            // degName = degName + s.Preferences[s.Preferences.Count - 1].title;
            // writer.WriteLine(s.name+","+s.age+","+s.FscMarks+","+s.EcatMarks+","+degName);
            // writer.Flush();
            // writer.Close();
        }
        public static bool ReadFromFile(string path)
        {
            StreamReader r = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = r.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');

                    // Ensure that the splittedRecord array has enough elements before accessing them
                    if (splittedRecord.Length >= 5)
                    {
                        try
                        {
                            string name = splittedRecord[0];
                            int age = int.Parse(splittedRecord[1]);
                            float fsc = float.Parse(splittedRecord[2]);
                            float ecat = float.Parse(splittedRecord[3]);

                            string[] splittedRecordByPreference = splittedRecord[4].Split(';');
                            List<DegreeProgram_BL> preferences = new List<DegreeProgram_BL>();
                            foreach (string preference in splittedRecordByPreference)
                            {
                                DegreeProgram_BL d = DegreeProgram_DL.IsDegreeExists(preference);
                                if (d != null && !preferences.Contains(d))
                                {
                                    preferences.Add(d);
                                }
                            }
                            Student_BL s = new Student_BL(name, age, fsc, ecat, preferences);
                            Student.Add(s);
                        }
                        catch (FormatException ex)
                        {
                            // Handle parsing errors
                            Console.WriteLine("Error parsing student record: " );
                        }
                    }
                    else
                    {
                        // Handle insufficient data in record
                        Console.WriteLine("Insufficient data in student record: ");
                    }
                }
                r.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}