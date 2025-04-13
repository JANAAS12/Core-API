using CoreApi.Server.IDataService;
using CoreApi.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Server.DataService
{
    public class Dataservice : IDataservice
    {

        private readonly MyDbContext _context;
        public Dataservice(MyDbContext context)
        {
            _context = context;
        }

        public List<Category> GetCategories()
        {
            var category = _context.Categories.ToList();
            return category;
        }


        public Category GetCategory(int id)
        {
            var category = _context.Categories.Find(id);
            
            return category;
        }
        public Category GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryName == name);
            return category;
        }
        public Category GetFirstCategory()
        {
            var category = _context.Categories.FirstOrDefault();
            return category;
        }

        public List<Product> GetProducts()
        {
            var product = _context.Products.ToList();
            return product;
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public Product GetProductByName(string name)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductsName == name);
            return product;
        }

        public Product GetFirstProduct()
        {
            var product = _context.Products.FirstOrDefault();
            return product;
        }

        public Category CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }








    }
}
