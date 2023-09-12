namespace MauiAppShellDemo.Views;

public partial class ElephantsPage : ContentPage
{
	public ElephantsPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("elephantdetails");
	}
}