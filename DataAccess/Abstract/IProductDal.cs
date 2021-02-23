using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add();
        void Update();
        void Delete();
        List<Product> GetAllByCategory(int categoryId);
    }
}
