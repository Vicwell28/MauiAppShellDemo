using MauiAppShellDemo.Views;

namespace MauiAppShellDemo;

public partial class TabBarAppShell : Shell
{
	public TabBarAppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("monkeydetails", typeof(MonkeyDetailPage));
		Routing.RegisterRoute("beardetails", typeof(BearDetailPage));
		Routing.RegisterRoute("catdetails", typeof(CatDetailPage));
		Routing.RegisterRoute("dogdetails", typeof(DogDetailPage));
		Routing.RegisterRoute("elephantdetails", typeof(ElephantDetailPage));
	}
}