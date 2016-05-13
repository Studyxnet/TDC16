using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TDC2016
{
	public partial class Workshop : ContentPage
	{
		public Workshop ()
		{
			InitializeComponent ();
		}


		public Workshop (int dia) : this ()
		{
			switch (dia) {
			case 1:
				quarta.IsVisible = true;
				break;
			case 2:

				quinta.IsVisible = true;
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
	}
}

