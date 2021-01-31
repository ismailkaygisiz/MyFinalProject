using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Tablo", UnitsInStock = 56, UnitPrice = 156},
                new Product{ProductId = 2, CategoryId = 2, ProductName = "Masa", UnitsInStock = 12, UnitPrice = 422},
                new Product{ProductId = 3, CategoryId = 2, ProductName = "Klavye", UnitsInStock = 124, UnitPrice = 421},
                new Product{ProductId = 4, CategoryId = 1, ProductName = "Mouse", UnitsInStock = 500, UnitPrice = 120},
                new Product{ProductId = 5, CategoryId = 2, ProductName = "Monitör", UnitsInStock = 20, UnitPrice = 1799}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
