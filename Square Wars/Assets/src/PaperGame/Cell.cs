using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.UI.DefaultControls;
using Resources = UnityEngine.Resources;

namespace PaperGame
{
	public class Cell : UnityEngine.Object
	{
		public enum Corner
		{
			LeftUp = 0,
			LeftDown = 1,
			RightUp = 2,
			RightDown = 3,
		}

		public static  int CellRadius = 1;

		public GameObject cell;
		// Start is called before the first frame update
		

		private Dictionary<Corner, Location> cornerLocation;
		public Dictionary<Corner, Location> CornerLocation { get { return cornerLocation; } }
		public IBuilding CurrentBuilding { get; private set; }

		public Cell() : this(0f, 0f) { }

		public Cell(Location loc) : this(loc.X, loc.Y) {

		}

		public Cell( float x , float y)
		{
			
			//cell.transform.position = new Vector3(x, y);
			//cell.transform.localScale = new Vector3(2 * CellRadius, 2 * CellRadius);
			cornerLocation = new Dictionary<Corner, Location>
			{
				{ Corner.LeftUp , new Location(x, y) },
				{ Corner.LeftDown , new Location(x, y + CellRadius) },
				{ Corner.RightUp , new Location(x + CellRadius, y) },
				{ Corner.RightDown , new Location(x + CellRadius, y + CellRadius) },
			};
		}

		public override string ToString()
		{
			var locationStr = "";
			cornerLocation.ToList().ForEach(s =>
			{
				locationStr += $"{s.Key} corner location is : {s.Value.ToString()}{Environment.NewLine}"; 
			});
			var buildingStr = Environment.NewLine + CurrentBuilding == null ? "does not have any building" : $"has 1 {CurrentBuilding.ToString()}";
			return locationStr + buildingStr;
		}

		/// <summary>
		/// addBuilding to cell
		/// </summary>
		/// <param name="build"></param>
		public void AddBuilding(IBuilding build)
		{
			if(CurrentBuilding == null)
			{
				CurrentBuilding = build;
			}
			// can not add a structure if alerady structure exist on cell
		}

		public bool IsAdjacent(Cell otherCell)
		{
			foreach(var t in this.CornerLocation)
			{
				foreach (var s in otherCell.CornerLocation)
				{
					if (t.Key.ToString() != s.Key.ToString())
					{
						if (t.Value == s.Value)
						{
							return true;
						}

						else
						{
							// This mean duplicate cells exist
						}
					}
				}
			}

			return false;
		}
	}
}
