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
        List<Product> _product;
        public InMemoryProductDal()
        {
            _product = new List<Product> {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitsInStock = 15, UnitPrice = 15 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitsInStock = 500, UnitPrice = 3 },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitsInStock = 1500, UnitPrice = 2 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitsInStock = 150, UnitPrice = 65 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitsInStock = 85, UnitPrice = 1 }
            };
        }
        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {

           
            

            //LINQ ile uyarlanması
            //Lambda
           Product  productToDelete = _product.SingleOrDefault(p=>p.ProductId ==product.ProductId);


            _product.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _product;
        }

        public List<Product> GetByCategory(int categoryId)
        {
           return  _product.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
          Product productToUpdate = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
