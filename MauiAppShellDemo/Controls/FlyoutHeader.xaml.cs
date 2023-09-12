using System.Diagnostics;

namespace MauiAppShellDemo.Controls;

public partial class FlyoutHeader : ContentView
{
	public FlyoutHeader()
	{
		InitializeComponent();
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		await Shell.Current.GoToAsync("Profile"); 
	}
}