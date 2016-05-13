using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TDC2016
{
	public partial class App : Application
	{
		public static string Cracha;
		public App ()
		{
			InitializeComponent ();

			MainPage = new Login ();
		}
	}
}

