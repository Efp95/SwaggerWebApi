using SalesApp.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesApp.Api
{
    public static class ProductData
    {
        private static ICollection<Product> _products;

        static ProductData()
        {
            _products = new List<Product>();

            _products.Add(new Product { Id = 1, Name = Guid.NewGuid().ToString(), Price = new Price { Amount = 3.5m } });
            _products.Add(new Product { Id = 2, Name = Guid.NewGuid().ToString(), Price = new Price { Amount = 5.7m } });
            _products.Add(new Product { Id = 3, Name = Guid.NewGuid().ToString(), Price = new Price { Amount = 1.2m } });
            _products.Add(new Product { Id = 4, Name = Guid.NewGuid().ToString(), Price = new Price { Amount = 0.9m } });
            _products.Add(new Product { Id = 5, Name = Guid.NewGuid().ToString(), Price = new Price { Amount = 12.4m } });
        }

        public static int Add(Product product)
        {
            int id = _products.Count + 1;
            product.Id = id;

            _products.Add(product);

            return id;
        }

        public static int Update(Product product)
        {
            var prod = _products.FirstOrDefault(p => p.Id == product.Id);
            if (prod != null)
            {
                prod.Name = product.Name;
                prod.Price = product.Price;
                return prod.Id;
            }

            throw new InvalidOperationException("Product does not exist!");
        }

        public static void Delete(int id)
        {
            var prod = _products.FirstOrDefault(p => p.Id == id);
            if (prod != null)
            {
                _products.Remove(prod);
            }

            throw new InvalidOperationException("Product does not exist!");
        }

        public static Product Get(int id)
        {
            var prod = _products.FirstOrDefault(p => p.Id == id);
            if (prod != null)
            {
                return prod;
            }

            throw new InvalidOperationException("Product does not exist!");
        }

        public static IEnumerable<Product> Get()
        {
            return _products;
        }
    }
}