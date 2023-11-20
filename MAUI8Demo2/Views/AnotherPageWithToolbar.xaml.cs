using static System.Net.Mime.MediaTypeNames;

namespace MAUI8Demo2.Views;

public partial class AnotherPageWithToolbar : ContentPage
{
	public AnotherPageWithToolbar()
	{
		Title = "2 buttons 1 Toolbar";
		InitializeComponent();


		this.ToolbarItems.Add(new ToolbarItem(null, "bug", () => DisplayAlert("Hi!", "Bug pressed", "Ok")) { Order = ToolbarItemOrder.Primary });

		this.ToolbarItems.Add(new ToolbarItem(null, "link", () => DisplayAlert("Hi!", "Link pressed", "Ok")) { Order = ToolbarItemOrder.Primary });

	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SimplePage());
	}
}