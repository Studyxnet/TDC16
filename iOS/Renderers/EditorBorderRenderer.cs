using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using TDC2016.iOS;
using CoreGraphics;

[assembly:ExportRenderer (typeof(Editor), typeof(EditorBorderRenderer))]
namespace TDC2016.iOS
{
	public class EditorBorderRenderer : EditorRenderer
	{
		public EditorBorderRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged (e);

			Control.Layer.BorderColor = Color.Gray.ToCGColor ();
			Control.Layer.BorderWidth = 0.5f;
		}
	}
}

