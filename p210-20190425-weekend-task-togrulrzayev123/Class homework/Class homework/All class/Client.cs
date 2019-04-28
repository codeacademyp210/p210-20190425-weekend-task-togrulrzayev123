using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework.All_class
{
    class Client:Person
    {
        public static int num = 0;
        public int GetNum()
        {
            num++;
            return num;

        }
        public int Client_Id { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
    }
}
