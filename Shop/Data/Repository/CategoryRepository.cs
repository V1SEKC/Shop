using System.CodeDom;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        //Реализуються в классах для работы с БД
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
