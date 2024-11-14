using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class Page1 : ContentPage
{
	public Page1(Page1ViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}