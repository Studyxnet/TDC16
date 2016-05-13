using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TDC2016
{
	public partial class Trilhas : CarouselPage
	{
		public Trilhas ()
		{
			InitializeComponent ();

			Children.Add (new Trilha (1));
			Children.Add (new Trilha (2));
			Children.Add (new Trilha (3));
			Children.Add (new Trilha (4));

			NavigationPage.SetBackButtonTitle (this, " ");
		}
	}
}

