using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),new Manager(),new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(), new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }


            ISalary[] salaries = new ISalary[2]
            {
                new Worker(), new Manager()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }


            Console.ReadLine();
        }
    }

    class Worker:IEat,IWorker,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void Work()
        {
            Console.WriteLine("Worker Work");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker GetSalary");
        }
    }

    class Manager:IEat,IWorker,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void Work()
        {
            Console.WriteLine("Manager Work");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager GetSalary");
        }
    }

    class Robot:IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
