using System.Diagnostics;

namespace MauiAppShellDemo.Controls;

public partial class FlyoutFooter : ContentView
{
	public FlyoutFooter()
	{
		InitializeComponent();
	}

	private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		Debug.WriteLine("qwertyui"); 
	}
}