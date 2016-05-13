using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;

namespace TDC2016
{
	public partial class Trilha : ContentPage
	{
		public Trilha ()
		{
			InitializeComponent ();

			BindingContext = this;	
		}

		public Trilha (int dia) : this ()
		{

			switch (dia) {
			case 1:
				quarta.IsVisible = true;
				Title = "1";
				break;
			case 2:
				quinta.IsVisible = true;
				Title = "2";
				break;
			case 3:
				sexta.IsVisible = true;
				break;
			case 4:
				sabado.IsVisible = true;
				break;
			default:
				break;
			}
		}

		public ICommand TrilhaCmd => new Command<string>((param)=> {AbrirFeedback(param);});

		public void AbrirFeedback(string Nome){
			var vm = new FeedbackViewModel(Nome);
			var page = new Feedback();
			page.BindingContext = vm;
			Navigation.PushAsync(page);	
		}
	}
}

