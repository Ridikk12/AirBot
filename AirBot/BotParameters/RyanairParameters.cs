using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBot.BotParameters
{
	public class RyanairParameters : Parameters
	{
		public string ADT { get; set; }
		public string CHD { get; set; }
		public string DateIn { get; set; }
		public string DateOut { get; set; }
		public string Destination { get; set; }
		public string FlexDaysIn { get; set; }
		public string FlexDaysOut { get; set; }
		public string INF { get; set; }
		public string Origin { get; set; }
		public string RoundTrip { get; set; }
		public string TEEN { get; set; }
		public string Exists { get; set; }

		public override string GetParameters()
		{
			return $@"ADT={ADT}&CHD={CHD}&DateIn={DateIn}&DateOut={DateOut}
						&Destination={Destination}&FlexDaysIn={FlexDaysIn}
						&FlexDaysOut={FlexDaysOut}&INF={INF}
						&Origin={Origin}&RoundTrip={RoundTrip}
						&TEEN={TEEN}&exists={Exists}";
		}
	}
}
