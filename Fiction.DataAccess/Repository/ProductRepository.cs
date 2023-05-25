using Fiction.DataAccess.Data;
using Fiction.DataAccess.Repository.IRepository;
using Fiction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiction.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _db;
        public ProductRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            var objFormDbb = _db.Products.FirstOrDefault(u=>u.ID == obj.ID);
            if (objFormDbb != null)
            {
                objFormDbb.Title = obj.Title;
                objFormDbb.ISBN = obj.ISBN;
                objFormDbb.Author = obj.Author;
                objFormDbb.Description = obj.Description;
                objFormDbb.ListPrice = obj.ListPrice;
                objFormDbb.Price50 = obj.Price50;
                objFormDbb.Price = obj.Price;
                objFormDbb.Price100 = obj.Price100;
                objFormDbb.CategoryID = obj.CategoryID;
                if(obj.ImageUrl != null)
                {
                    objFormDbb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
