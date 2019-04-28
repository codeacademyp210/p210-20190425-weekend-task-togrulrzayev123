using Class_homework.All_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person prsn = new Person();
            Employee emp = new Employee();
            Client clyn = new Client();
            Product pdr = new Product();
            Order order = new Order();

            Console.WriteLine("Zehmet olmasa,Secim edin:");
            Console.WriteLine("I,i-Ishci yaratmaq");
            Console.WriteLine("M,m-Mushteri yaratmaq");
            Console.WriteLine("P,p-Mehsul yaratmaq");
            Console.WriteLine("O,o-Sifarish yaratmaq");

             char myletter;
             bool operConverted;

            do
            {
                operConverted = Char.TryParse(Console.ReadLine(), out  myletter);
                if (!operConverted)
                {
                    Console.WriteLine("Please enter your letter i,m,p,o");
                }
                else if (myletter == 'i' || myletter == 'I')
                {
                    Console.WriteLine("Please enter your Name");
                    emp.Name = Console.ReadLine();

                    Console.WriteLine("Please enter your Surname");
                    emp.SurName = Console.ReadLine();

                    Console.WriteLine("Please enter your Birthday Year");
                    emp.BirthDay_Year = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your Card_Id");
                    emp.Card_Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your Position");
                    emp.Position = Console.ReadLine();

                    Console.WriteLine("Please enter your Salary");
                    emp.Salary = Convert.ToInt16(Console.ReadLine());

                    var id = emp.GetNum();

                    var today = DateTime.Now.Year;
                    var ages = today - emp.BirthDay_Year;

                    emp.age = ages;

                    Console.WriteLine($"Ishci yaradildi. {id} - {emp.Name} {emp.SurName} {emp.age}");

                    Console.WriteLine("Zehmet olmasa,Secim edin:");
                    Console.WriteLine("I,i-Ishci yaratmaq");
                    Console.WriteLine("M,m-Mushteri yaratmaq");
                    Console.WriteLine("P,p-Mehsul yaratmaq");
                    Console.WriteLine("O,o-Sifarish yaratmaq");
                }
                else if (myletter == 'm' || myletter == 'M')
                {
                    Console.WriteLine("Please enter your Name");
                    clyn.Name = Console.ReadLine();

                    Console.WriteLine("Please enter your Surname");
                    clyn.SurName = Console.ReadLine();

                    Console.WriteLine("Please enter your Birthday Year");
                    clyn.Birthday = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your Card_Id");
                    clyn.Card_Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your Client_Id");
                    clyn.Client_Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter your Adress");
                    clyn.Adress = Console.ReadLine();

                    Console.WriteLine("Please enter your Phone");
                    clyn.Phone = Convert.ToInt32(Console.ReadLine());

                    var id = clyn.GetNum();

                    Console.WriteLine($"Mushteri yaradildi. {id} - {clyn.Name} {clyn.SurName}");

                    Console.WriteLine("Zehmet olmasa,Secim edin:");
                    Console.WriteLine("I,i-Ishci yaratmaq");
                    Console.WriteLine("M,m-Mushteri yaratmaq");
                    Console.WriteLine("P,p-Mehsul yaratmaq");
                    Console.WriteLine("O,o-Sifarish yaratmaq");

                }
                else if (myletter == 'p' || myletter=='P')
                {
                    Console.WriteLine("Please enter your Name");
                    pdr.Name = Console.ReadLine();

                    Console.WriteLine("Please enter your Surname");
                    pdr.Color = Console.ReadLine();

                    Console.WriteLine("Please enter your Price");
                    pdr.Price = Convert.ToInt32(Console.ReadLine());

                    var id = pdr.GetNum();

                    Console.WriteLine($"Mehsul  yaradildi. {id} - {pdr.Name} {pdr.Color} {pdr.Price} Man");

                    Console.WriteLine("Zehmet olmasa,Secim edin:");
                    Console.WriteLine("I,i-Ishci yaratmaq");
                    Console.WriteLine("M,m-Mushteri yaratmaq");
                    Console.WriteLine("P,p-Mehsul yaratmaq");
                    Console.WriteLine("O,o-Sifarish yaratmaq");
                }
                else if (myletter == 'o' || myletter == 'O')
                {
                    Console.WriteLine("Please enter count");
                    order.Count = Convert.ToInt32(Console.ReadLine());

                    int id = order.GetNum();


                    Console.WriteLine($"Sifarish yaradildi. {id} -Mehsul {clyn.Name} terefinden sifarish olundu. Sayi: {order.Count}, Cemi Mebleg: {order.Count * pdr.Price} Manat.  Sifarishi qebul eden ishci:{emp.Name} {emp.SurName} {emp.Position}");

                    Console.WriteLine("Zehmet olmasa,Secim edin:");
                    Console.WriteLine("I,i-Ishci yaratmaq");
                    Console.WriteLine("M,m-Mushteri yaratmaq");
                    Console.WriteLine("P,p-Mehsul yaratmaq");
                    Console.WriteLine("O,o-Sifarish yaratmaq");
                }
                else
                { 
                    Console.WriteLine("Please enter i,m,p,o");
                }

            } while (operConverted);

            Console.Read();
        }
    }
}
