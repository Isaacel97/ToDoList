using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToDoList.ViewModels
{
	public partial class MainViewModel : ObservableObject
	{
		[ObservableProperty]
		private string mensaje = "	Click";
		private int count;
		public MainViewModel()
		{
		}

		[RelayCommand]
		private void Increment()
		{
			count++;
			Mensaje = $"Clicks {count}";
		}

		[RelayCommand]
		private void StartApp()
		{
			Shell.Current.GoToAsync("TO_DO");
		}
	}
}

