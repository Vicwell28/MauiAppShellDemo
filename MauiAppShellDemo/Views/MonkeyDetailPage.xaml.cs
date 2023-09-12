using MauiAppShellDemo.Services.DeviceInfoService;
using System.Diagnostics;

namespace MauiAppShellDemo.Views;

public partial class MonkeyDetailPage : ContentPage
{

	public MonkeyDetailPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(".."); 
	}
}