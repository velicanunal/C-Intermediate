using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(15);
            customerManager.List();

            Console.WriteLine("**********");

            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.List();

            Console.WriteLine("**************");

            Product product = new Product(1,"Laptop");
            Product product2 = new Product() {Id = 2, Name = "Computer"};

            Console.WriteLine("*******");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=10;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int _id;
        private string _name;

        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }

        public Product()
        {
            
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to Database");
        }
    }
    class FileLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to File");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }
}
