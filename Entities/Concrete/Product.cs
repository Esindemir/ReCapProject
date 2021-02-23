using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity 
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int Modelyear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public object CategoryId { get; set; }
    }
}
