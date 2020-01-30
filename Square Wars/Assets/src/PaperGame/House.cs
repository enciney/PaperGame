using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGame
{
	public class House : Building
	{
		public House()
		{
			price = 100;
			gain = 10;
			population = 2;
		}

		public override string ToString()
		{
			return "House";
		}

	}
}
