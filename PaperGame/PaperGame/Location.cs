using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGame
{
	public class Location
	{
		public double X { get; }
		public double Y { get; }

		public Location()
		{
			X = 0;
			Y = 0;
		}

		public Location(double X, double Y)
		{
			this.X = X;
			this.Y = Y;
		}

		public override string ToString()
		{
			return $"({X},{Y})";
		}

		public static bool operator ==(Location thisLoc, Location otherLoc)
		{
			return (thisLoc.X == otherLoc.X) && (thisLoc.Y == otherLoc.Y);
		}

		public static bool operator !=(Location thisLoc, Location otherLoc)
		{
			return !((thisLoc.X == otherLoc.X) && (thisLoc.Y == otherLoc.Y));
		}

	}
}
