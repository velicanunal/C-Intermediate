using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //birincisi key,ikincisi value
            dictionary.Add("table","masa");
            dictionary.Add("bottle","şişe");
            dictionary.Add("phone","telefon");

            foreach (var item in dictionary)
            {
                //Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("Var mı=> {0}",dictionary.ContainsKey("glass"));
            Console.WriteLine("Var mı=> {0}", dictionary.ContainsKey("table"));


            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            Console.WriteLine("*******************");

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() {Id = 1, FirstName = "Veli Can"});
            customers.Add(new Customer() {Id = 2, FirstName = "Sena"});


            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

        }

        private static void ArrayList()
        {
            //çalışacağımız listede belli bir tip yoksa yani tipler karışıksa orda Arraylist kullanırız
            ArrayList cities = new ArrayList();
            cities.Add("Adana");
            cities.Add("Ankara");

            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
