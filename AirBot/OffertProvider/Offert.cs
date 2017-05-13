using AirBot.BotParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBot.OffertProvider
{
	public abstract class Offert
	{
		public string OffertUrl { get; set; }
		protected Parameters _parameters;
		public abstract string GetUrlToOFfert();
	}
}
