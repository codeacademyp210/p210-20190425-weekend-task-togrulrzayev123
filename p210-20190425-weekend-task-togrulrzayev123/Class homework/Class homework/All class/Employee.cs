using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework.All_class
{
    class Employee:Person
    {
        public static int num = 0;
        public int GetNum()
        {
            num++;
            return num;

        }
        internal object age;
        public int BirthDay_Year { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

    }
}
