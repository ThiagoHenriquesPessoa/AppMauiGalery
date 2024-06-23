using AppMauiGalery.Model;
using AppMauiGalery.Views.Layouts;

namespace AppMauiGalery.Repositories;

public class CategoryRepository
{
    public CategoryRepository() { }
    public List<Category> GetCategories()
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category
        {
            Name = "Layout",
            Components = new List<Componets>
            {
                new Componets
                {
                    Title = "StackLayout",
                    Description="Organização sequencial dos elementos",
                    Page = new StackLayoutPage()
                }
            }
        });

        return categories;
    }
}