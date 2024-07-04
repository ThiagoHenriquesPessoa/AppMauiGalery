using AppMauiGalery.Repositories;

namespace AppMauiGalery.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

		var categories = new CategoryRepository().GetCategories();

		foreach (var category in categories)
		{
            var lblCategory = new Label();
            lblCategory.Text = category.Name;

            MenuContainerr.Children.Add(lblCategory);
            foreach (var component in category.Components)
			{
				var lblComponentTitle = new Label();
				lblComponentTitle.Text = component.Title;

                var lblComponentDescription = new Label();
                lblComponentDescription.Text = component.Description;

                MenuContainerr.Children.Add(lblComponentTitle);
                MenuContainerr.Children.Add(lblComponentDescription);
            }
        }


	}
}