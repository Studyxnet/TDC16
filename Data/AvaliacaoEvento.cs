using System;

namespace TDC2016
{
	public class EventFeedback
	{

			[Microsoft.WindowsAzure.MobileServices.Version]
			public string AzureVersion { get; set; }

			[Newtonsoft.Json.JsonProperty ("Id")]
			public string Id {
				get;
				set;
			}

			public string IDCracha {
				get;
				set;
			}

		public string avEvento {
			get;
			set;
		}

		public string avNetworking {
			get;
			set;
		}

		public string avOrganizacao {
			get;
			set;
		}

		public string avAlimentacao {
			get;
			set;
		}

		public string avCusto {
			get;
			set;
		}
			
	}

	public class TrackFeedback
	{
		[Microsoft.WindowsAzure.MobileServices.Version]
		public string AzureVersion { get; set; }

		[Newtonsoft.Json.JsonProperty ("Id")]
		public string Id {
			get;
			set;
		}

		public string IDCracha {
			get;
			set;
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

		public string avConteudo {
			get;
			set;
		}

		public string avApresentacao {
			get;
			set;
		}

		public string avPalestrante {
			get;
			set;
		}

		public string avCoordenador {
			get;
			set;
		}
	}
}

