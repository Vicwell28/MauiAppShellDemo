namespace MauiAppShellDemo.Views;

public partial class ViewTabBar : ContentView
{
	public ViewTabBar()
	{
		InitializeComponent();
	}

	private void OnTabSelected(object sender, System.EventArgs e)
	{
		if (sender == Tab1Button)
			TabCarousel.Position = 0;
		else if (sender == Tab2Button)
			TabCarousel.Position = 1;
	}
}