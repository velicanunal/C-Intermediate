using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> cities = utilities.BuildList<string>("Ankara", "Adana");
            foreach (var city in cities)
            {
                Console.WriteLine(city);   
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    //t tipi referans tip ve newlenebilir olmalı
    interface IRepository<T> where T:class ,new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    interface IProduct:IRepository<Product>
    {
        
    }

     class Product
    {
    }

     class ProductDal:IProduct
     {
         public List<Product> GetAll()
         {
             throw new NotImplementedException();
         }

         public Product Get(int id)
         {
             throw new NotImplementedException();
         }

         public void Add(Product entity)
         {
             throw new NotImplementedException();
         }

         public void Delete(Product entity)
         {
             throw new NotImplementedException();
         }

         public void Update(Product entity)
         {
             throw new NotImplementedException();
         }
     }
}
