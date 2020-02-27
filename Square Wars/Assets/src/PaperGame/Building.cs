using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGame
{
	public abstract class Building : IBuilding
	{
		protected int price;
		protected int gain;
		protected int population;
		protected IEnumerable<Cell> location;

		public int Price { get { return price; } }
		public int Gain { get { return gain; } }
		public int Population { get { return population; } }
		public IEnumerable<Cell> Location { get { return location; } }
	
	}
}
