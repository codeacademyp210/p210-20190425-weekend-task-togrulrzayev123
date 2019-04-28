using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework.All_class
{
    class Product
    {
        public static int num = 0;
       
        public int GetNum()
        {
            num++;
            return num;
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
    }
}
