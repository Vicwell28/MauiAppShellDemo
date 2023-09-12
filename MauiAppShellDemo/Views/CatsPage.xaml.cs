namespace MauiAppShellDemo.Views;

public partial class CatsPage : ContentPage
{
	public CatsPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("monkeydetails");
	}
}