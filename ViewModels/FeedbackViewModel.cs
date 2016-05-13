using System;

namespace TDC2016
{
	public class FeedbackViewModel
	{
		string _default = "Deixe aqui suas criticas e sugestões para esta trilha.";

		public FeedbackViewModel ()
		{
			Observacao = _default;
		}

		public FeedbackViewModel (string _nome) : this ()
		{
			Nome = _nome;	
		}

		public string Nome {
			get;
			set;
		}

		public bool Gostou {
			get;
			set;
		}

		public string Observacao {
			get;
			set;
		}
	}
}

