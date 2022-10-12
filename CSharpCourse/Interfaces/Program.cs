using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //RealLifeInterfaceDemo1();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new OracleCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }

            Console.ReadLine();
        }

        private static void RealLifeInterfaceDemo1()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer {Id = 1, FirstName = "Veli Can", LastName = "ÜNAL", Adress = "Adana"});
            manager.Add(new Student() {Id = 1, FirstName = "Sena", LastName = "ÜNAL", Department = "Yazılım"});
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
        
    }

    class Student:IPerson
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Sir. "+person.FirstName+" added :) ");
        }
    }
}
