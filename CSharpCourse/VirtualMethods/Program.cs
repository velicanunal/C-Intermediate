using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Mysql mysql = new Mysql();
            mysql.Add();

            SqlServer server = new SqlServer();
            server.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }

    }

    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by sql server");
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted to Sql Server");
        }
    }

    class Mysql:Database
    {
        
    }

}
