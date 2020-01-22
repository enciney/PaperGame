using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var cell = new Cell(2.2, 5.7);
			cell.AddBuilding(new House());
			var cellStr = cell.ToString();
		}
	}
}
