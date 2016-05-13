using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TDC2016
{
	public partial class FeedbackEvento : ContentPage
	{
		AzureServices azureService;

		public FeedbackEvento ()
		{
			InitializeComponent ();

			NavigationPage.SetBackButtonTitle (this, " ");

			azureService = new AzureServices ();
		}

		void salvarClick (object sender, EventArgs e)
		{
			insert ();
		}

		async Task insert ()
		{
			try {
				
				await azureService.Initialize ();

				azureService.AddAv (pkEvento.SelectedIndex.ToString (),
					pkENetworking.SelectedIndex.ToString (),
					pkOrg.SelectedIndex.ToString (),
					pkAlimentacao.SelectedIndex.ToString (),
					pkCusto.SelectedIndex.ToString ());
				
				await DisplayAlert ("Obrigado", "Sua avaliação foi salva", "OK");

				Navigation.PopAsync ();

			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
		}
	}
}

