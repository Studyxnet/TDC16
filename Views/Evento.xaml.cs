using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TDC2016
{
	public partial class Evento : ContentPage
	{
		public Evento ()
		{
			InitializeComponent ();

			NavigationPage.SetBackButtonTitle (this, " ");
		}

		void about_Clicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new About ());
		}

		void avEvento_Clicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new FeedbackEvento ());
		}

		void avPatroc_Clicked (object sender, EventArgs e)
		{
			Navigation.PushAsync (new Patrocinadores ());
		}
	}
}

