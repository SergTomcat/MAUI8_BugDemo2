using MAUI8Demo2.Views;

namespace FlyoutPageSample;

public partial class AppFlyout : FlyoutPage
{
     public AppFlyout()
     {
		InitializeComponent();

        flyoutPage.collectionView.SelectionChanged += OnSelectionChanged;
    }

    void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as FlyoutPageItem;
        if (item != null)
        {
               Page newPage;
               switch (item.Id) {
                    case "tbbtn":
                         newPage = new PageWithToolbar();
					NavigationPage.SetTitleView(newPage, new Label() { Text = newPage.Title, WidthRequest = 200, BackgroundColor = Colors.Orange });

					newPage = new NavigationPage(newPage);
					break;
                    case "2tbbtns":
                         newPage = new AnotherPageWithToolbar();
					NavigationPage.SetTitleView(newPage, new Label() { Text = newPage.Title, WidthRequest = 200, BackgroundColor = Colors.Yellow });

                         newPage = new NavigationPage(newPage);

					break;
				default:
                         newPage = new SimplePage();
					NavigationPage.SetTitleView(newPage, null);
					break;
                         
			}

               Detail = newPage;
        }
    }
}