using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Data Added to Sql Server");
        }

        public void Update()
        {
            Console.WriteLine("Data Updated to Sql Server");
        }

        public void Delete()
        {
            Console.WriteLine("Data Deleted to Sql Server");
        }
    }


    class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Data Added to Oracle");
        }

        public void Update()
        {
            Console.WriteLine("Data Updated to Oracle");
        }

        public void Delete()
        {
            Console.WriteLine("Data Deleted to Oracle");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }

        public void Delete(ICustomerDal customer)
        {
            customer.Delete();
        }

        public void Update(ICustomerDal customer)
        {
            customer.Update();
        }
    }
}
