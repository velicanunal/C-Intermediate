using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = CustomerManager.CreateAsSingleton();
            result.Save();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private static CustomerManager _customerManager;
        private static object _lockObject;

        public CustomerManager()
        {
            
        }

        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager != null) return _customerManager;
                _customerManager = new CustomerManager();
            }

            return _customerManager;
            //return _customerManager ?? (_customerManager = new CustomerManager());
        }

        public void Save()
        {
            Console.WriteLine("Saved!!!");
        }
    }
}
