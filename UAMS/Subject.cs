﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Subject
    {
        public string code;
        public string type;
        public int creditHours;
        public int Subjectfee;
        
        public Subject()
        {
            ///Empty Constructor
        }
        public Subject(string code, string type, int creditHours, int Subjectfee)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.Subjectfee = Subjectfee;
        }

    }
}
