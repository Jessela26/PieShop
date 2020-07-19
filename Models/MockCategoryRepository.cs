using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Fruit Pies", Description="All-fruit"},
                new Category{CategoryId=2, CategoryName="Cheese Cakes", Description="Cheesy textured pies"},
                new Category{CategoryId=3, CategoryName="Seasonal Pies", Description="Get in the season pies"},
                new Category{CategoryId=4, CategoryName="Chocolate Pies", Description="Sweet and decadent pies"},
                new Category{CategoryId=5, CategoryName="Meat Pies", Description="Savory and delicious pies"}
            };
    }
}
