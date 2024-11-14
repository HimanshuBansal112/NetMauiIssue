using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		[RelayCommand]
		async Task TapPage1()
		{
			await Shell.Current.GoToAsync(nameof(Page1));
		}
	}
}
