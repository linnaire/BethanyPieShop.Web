using System;
using System.Collections.Generic;

namespace BethanyPieShop.Web
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAll() =>
            new List<Category>
            {
                new Category { CategoryId = 1, Name = "Fruit Pie", Description = "All-fruity pie" },
                new Category { CategoryId = 1, Name = "Cheese Cake", Description = "Cheesy all the way" },
                new Category { CategoryId = 1, Name = "Seasonal Pie", Description = "Get in the mood for a seasonal pie" }
            };

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
