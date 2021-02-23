using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId = 1, BrandId = 2,ProductName="Car", ColorId = 3, Modelyear = 1935, DailyPrice = 15000, Description = "Son zamanlarda en çok satılan ürün" }
            };
        }



        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == p.CategoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.CategoryId = product.CategoryId;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
