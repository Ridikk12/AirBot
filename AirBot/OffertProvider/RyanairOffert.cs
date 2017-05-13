using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirBot.BotParameters;

namespace AirBot.OffertProvider
{
	public class RyanairOffert : Offert
	{

		public RyanairOffert(string offertUrl, RyanairParameters offertParameters)
		{
			OffertUrl = offertUrl;
			_parameters = offertParameters;
		}

		public override string GetUrlToOFfert()
		{
			return OffertUrl + _parameters.GetParameters();
		}
	}
}
