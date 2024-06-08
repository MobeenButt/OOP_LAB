using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Mobeen",14,3.5f,1096,972,220,"Lahore",false,false);
            float merit = student.CalculateMerit();
            Console.WriteLine($"Merit of {student.name}: {merit}");

            float meritPercentage = 85; // suppose merit percentage obtained
            bool isEligible = student.IsEligibleForScholarship(meritPercentage);
            Console.WriteLine($"Is {student.name} eligible for scholarship? {isEligible}");
            Console.ReadLine();
        }

    }
}
