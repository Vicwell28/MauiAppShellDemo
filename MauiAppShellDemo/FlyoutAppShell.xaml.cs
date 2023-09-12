using MauiAppShellDemo.Views;

namespace MauiAppShellDemo;

public partial class FlyoutAppShell : Shell
{
	public FlyoutAppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("Profile", typeof(MonkeyDetailPage));
		Routing.RegisterRoute("beardetails", typeof(BearDetailPage));
		Routing.RegisterRoute("catdetails", typeof(CatDetailPage));
		Routing.RegisterRoute("dogdetails", typeof(DogDetailPage));
		Routing.RegisterRoute("elephantdetails", typeof(ElephantDetailPage));
	}
}