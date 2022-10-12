using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("****************");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.WriteLine("**************");

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Veli Can";
            customer.LastName  = "ÜNAL";
            customer.City = "Adana";

            Customer customer2 = new Customer
            {
                Id = 2, FirstName = "Sena",LastName = "GÜNGÖR ÜNAL", City = "Adana"
            };


            Console.ReadLine();
        }
    }

}
