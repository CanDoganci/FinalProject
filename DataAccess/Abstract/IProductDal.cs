using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();

        //Interface metodları default olarak public dir.
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);


        List<Product> GetByCategory(int categoryId);
    }
}
