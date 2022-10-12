using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            if (number == 10)
            {
                Console.WriteLine("Sayı 10");
            }
            else 
            {
                Console.WriteLine("Sayı 10 değil");
            }

            //if koşulunun yeni nesil yazımı (Single line if)
            Console.WriteLine(number == 10 ? "Sayı 10dur" : "Sayı 10a eşit değil");

            var number2 = 25;
            switch (number2)
            {
                case 25:
                    Console.WriteLine("Sayı 25");
                    break;
                case 30:
                    Console.WriteLine("Sayı 30");
                    break;
                default:
                    Console.WriteLine("Sayı 25 yada 30 değil");
                    break;
            }


            Console.ReadLine();
        }
    }
}
