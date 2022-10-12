using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //integer veri tipi değer tipidir
            int number1 = 10;
            //köşeli parantez içerisindeki sayı index belirtir virgülden sonraki indexi yazdır demektir
            Console.WriteLine("Number1 is {0}",number1);
            //long veri tip integerın 2 katı kadar bellekte yer kaplar
            //long 64 bitlik yer kaplar
            long number2 = 25463155845;
            Console.WriteLine("Number2 is {0}", number2);
            //short veri tipi 16 bitlik yer tutar 
            short number3=32767;
            Console.WriteLine("Number3 is {0}", number3);
            //byte veri tipi 0 ile 255 arasında değer tutar
            byte number4 = 255;
            Console.WriteLine("Number4 is {0}", number4);
            //bool true yada false değeri tutar
            bool condition = true;
            Console.WriteLine("Condition is {0}", condition);
            char character = 'A';
            Console.WriteLine("Character is {0}", character);
            //double 64 bit yer tutar
            double number5 = 10.4;
            Console.WriteLine("Number5 is {0}", number5);
            //decimal veri tipi int için long neyse double için decimal odur
            decimal number6 = 10.4m;
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Days is {0}", Days.Pazartesi);

            //var veri tipinde başta ne verdiysen o veri tipyle devam eder
            var number7 = 10;
            Console.WriteLine("number7 is {0}", number7);



            Console.ReadLine();
        }
    }

    enum Days
    {
        Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar
    }
}
