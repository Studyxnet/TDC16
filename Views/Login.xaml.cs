using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;
using System.Linq;

namespace TDC2016
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();

			BindingContext = this;

		}

		public ICommand LoginCmd => new Command(AbrirTrilhas);

		public async void AbrirTrilhas(){

			if(string.IsNullOrEmpty( cracha.Text)){
				DisplayAlert("Erro","Preencha o campo com o número do seu cracha","OK");	
			}else if(int.Parse(cracha.Text)<99){
				DisplayAlert("Erro","Informe um ID válido","OK");	
			}
			else if(int.Parse(cracha.Text)>999999){
				DisplayAlert("Erro","Informe um ID válido","OK");	
			}
			else{
				try {
					var res=await new RestFullAcess<string[]>().Get("http://www.suaapi.com.br/",cracha.Text,"Get");
					if(res.Any()){
						App.Cracha = cracha.Text;
						App.Current.MainPage =  new Master();
					}

				} catch (Exception ex) {

				}
			}
		}
	}
}


