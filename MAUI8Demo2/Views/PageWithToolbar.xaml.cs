namespace MAUI8Demo2.Views;

public partial class PageWithToolbar : ContentPage
{
	public PageWithToolbar()
	{
		Title = "Toolbar and button";
		InitializeComponent();

		this.ToolbarItems.Add(new ToolbarItem(null, "star", () => DisplayAlert("Hi!", "Star pressed", "Ok")) { Order = ToolbarItemOrder.Primary });
	}
}