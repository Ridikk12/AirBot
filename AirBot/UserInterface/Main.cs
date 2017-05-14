using AirBot.BotParameters;
using AirBot.OffertProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBot
{
	public partial class Form1 : Form
	{
		private AirProvider _privider;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RyanairParameters param = new RyanairParameters();
			param.ADT = "2";
			param.CHD = "0";
			param.DateIn = "2017-08-17";
			param.DateOut = "2017-08-10";
			param.Destination = "LPA";
			param.Origin = "KRK";
			param.INF = "0";
			param.TEEN = "0";
			param.FlexDaysIn = "6";
			param.FlexDaysOut = "4";
			param.Exists = "false";
			param.RoundTrip = "true";

			RyanairOffert offert = new RyanairOffert(Config.RyanairFlyURL, param);
			_privider = new AirProvider(new System.Net.WebClient(), offert);
			_privider.Get();

		}
	}
}
