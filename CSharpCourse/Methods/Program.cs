using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = Add(10,60);
            //Console.WriteLine(result);
            Console.WriteLine(Multipy(2,3));
            Console.WriteLine(Multipy(2,3,6));
            Console.WriteLine(Add(1,2,3,4,5,6,7,8,9,10));
            Console.ReadLine();
        }

        static int Add(int number1,int number2)
        {
            var result = number1 + number2;
            return result;
        }

        //aynı isimle birden fazla iki method çağırılabilir fakat parametre sayıları farklı olacak buna method overloading denir 
        static int Multipy(int i,int j)
        {
            return i *j;
        }
        static int Multipy(int i,int j,int k)
        {
            return i * j * k;
        }

        //params methodu gönderilecek parametre sayısı değişebileceği zaman kullanılır
        static int Add(params int[] numbers) 
        {
            return numbers.Sum();
        }
    }
}
