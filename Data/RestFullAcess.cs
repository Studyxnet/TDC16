using System;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net.Http;

namespace TDC2016
{
	public class RestFullAcess<T>
	{

		public async Task<T> Get (string URL, string Param, string HttpVerb)
		{

			var client = new System.Net.Http.HttpClient ();
			client.DefaultRequestHeaders.Accept.Add (
				new MediaTypeWithQualityHeaderValue ("application/json"));

			var response = await client.GetAsync (URL + Param);

			var JsonResult = response.Content.ReadAsStringAsync ().Result;

			var rootobject = JsonConvert.DeserializeObject<T> (JsonResult);

			return rootobject;
		}

		public async Task<bool> Post (T objeto, string URL, string Metodo)
		{
			try {

				var client = new System.Net.Http.HttpClient ();
				client.DefaultRequestHeaders.Accept.Add (
					new MediaTypeWithQualityHeaderValue ("application/json"));

				var content = new StringContent (JsonConvert.SerializeObject (objeto));

				var response = await client.PostAsync (URL + Metodo, content);

				return response.IsSuccessStatusCode;
			} catch (Exception) {
				return false;
			}
		}

	}
}

