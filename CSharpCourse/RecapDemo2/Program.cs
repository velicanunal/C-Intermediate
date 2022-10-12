﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new SmsLogger();
            customerManager.Add();
            Console.ReadLine();
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
            Console.WriteLine("Log to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to file");
        }
    }

    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to sms");
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }
}
