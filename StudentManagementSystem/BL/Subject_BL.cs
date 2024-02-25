using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.BL
{
    internal class Subject_BL
    {
        public string code;
        public int creditHours;
        public string subjectType;
        public float subjectFee;

        public Subject_BL(string code, int creditHours, string subjectType,float subjectFee)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.subjectType = subjectType;
            this.subjectFee = subjectFee;
        }
    }
}
