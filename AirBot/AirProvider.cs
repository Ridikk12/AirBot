using AirBot.OffertProvider;
using System.Net;
namespace AirBot
{
	class AirProvider
	{
		private WebClient _webClient;
		private Offert _airOffert;

		public AirProvider(WebClient client, RyanairOffert offert)
		{
			_webClient = client;
			_airOffert = offert;
			
		}

		public void Get()
		{
			var result = _webClient.DownloadString(_airOffert.GetUrlToOFfert());
		}
	}
}
