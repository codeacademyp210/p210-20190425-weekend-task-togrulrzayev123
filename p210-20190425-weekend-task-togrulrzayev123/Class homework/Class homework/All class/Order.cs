using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework.All_class
{
  
    class Order
    {
        Product pdr = new Product();
        public static int num = 0;

        public int GetNum()
        {
            num++;
            return num;
        }  
        public Client Client { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
       
    }
}
