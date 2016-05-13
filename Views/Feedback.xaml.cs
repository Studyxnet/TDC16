using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;

namespace TDC2016
{
	public partial class Feedback : ContentPage
	{
		AzureServices azureService;

		public Feedback ()
		{
			InitializeComponent ();
			azureService = new AzureServices ();

		}

		async void salvarClick (object sender, EventArgs e)
		{
			var bc = BindingContext as FeedbackViewModel;

			var tcAv = new TrackFeedback ();
			tcAv.Gostou = bc.Gostou;
			tcAv.Observacao = bc.Observacao;
			tcAv.IDCracha = App.Cracha;
			tcAv.avConteudo = pkConteudo.SelectedIndex.ToString ();
			tcAv.avApresentacao = pkApresentacao.SelectedIndex.ToString ();
			tcAv.avPalestrante = pkPalestrante.SelectedIndex.ToString ();
			tcAv.avCoordenador = pkCoordenador.SelectedIndex.ToString ();

			try {

				await azureService.Initialize ();

				azureService.AddAv (tcAv);

				await DisplayAlert ("Obrigado", "Sua avaliação foi salva", "OK");

				Navigation.PopAsync ();

			} catch (Exception ex) {
				Debug.WriteLine (ex);
			}
		}
	}
}

