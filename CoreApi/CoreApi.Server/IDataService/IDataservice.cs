using CoreApi.Server.Models;

namespace CoreApi.Server.IDataService
{
    public interface IDataservice
    {

        public List<Category> GetCategories();
        public Category GetFirstCategory();
        public Category GetCategoryByName(string name);
        public Category GetCategory(int id);

        public List<Product> GetProducts();
        public Product GetFirstProduct();
        public Product GetProductByName(string name);
        public Product GetProduct(int id);















    }
}
