using System;
using Xamarin.Forms;

namespace TDC2016
{
	public class Master : TabbedPage
	{
		public Master ()
		{
			Children.Add (new NavigationPage (new Evento ()) {
				Title = "TDC 2016",
				Icon = "fa-tdc.png"
			});
			Children.Add (new NavigationPage (new Trilhas ()) {
				Title = "Trilhas",
				Icon = "fa-cube.png"
			});
			Children.Add (new NavigationPage (new Workshops ()) {
				Title = "Workshops",
				Icon = "fa-flask.png"
			});

//			Master = new ContentPage () { 
//				Content = new StackLayout(){
//					Children = {
//						new Button(){
//							Text ="Trilhas"
//						},
//						new Button(){
//							Text ="Workshops"
//						}
//					}
//				},
//				Title = "Master"
//			};

		}
	}
}

