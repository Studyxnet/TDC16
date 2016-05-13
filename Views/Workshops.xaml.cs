using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TDC2016
{
	public partial class Workshops : CarouselPage
	{
		public Workshops ()
		{
			InitializeComponent ();

			Children.Add (new Workshop (1));
			Children.Add (new Workshop (2));
			Children.Add (new Workshop (3));
			Children.Add (new Workshop (4));

			NavigationPage.SetBackButtonTitle (this, " ");
		}
	}
}

