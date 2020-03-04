using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.UI.DefaultControls;
using Resources = UnityEngine.Resources;

namespace PaperGame
{
	public class Cell : MonoBehaviour
	{
		public static int Radius = 5;
		private GameObject cellObject;
		public GameObject CellObject { get { return cellObject; } }
		private Dictionary<Corner, Location> cornerLocation;
		public Dictionary<Corner, Location> CornerLocation { get { return cornerLocation; } }
		public Location ExactLocation {get { return exactLocation;} }
		private Location exactLocation;
		private Color32 cellColor;
		public Color32 CellColor { get { return cellColor; } }
		public IBuilding CurrentBuilding { get; private set; }

		public void Init(Location loc, GameObject obj, Color32 color) => Init(loc.X, loc.Y, obj, color);

		public void Init(float x, float y, GameObject obj, Color32 color)
		{
			exactLocation = new Location(x,y);
			cellObject = obj;
			cellObject.transform.position = new Vector3(x, y);
			cellObject.transform.localScale = new Vector3(2 * Radius, 2 * Radius);
			cellColor = color;
			var renderer = cellObject.GetComponent<SpriteRenderer>();
			renderer.material.color = cellColor;
			renderer.material.SetColor("_Color", cellColor); 
			cornerLocation = new Dictionary<Corner, Location>
			{
				{ Corner.LeftUp , new Location(x - Radius, y + Radius) },
				{ Corner.LeftDown , new Location(x - Radius, y - Radius) },
				{ Corner.RightUp , new Location(x + Radius, y + Radius) },
				{ Corner.RightDown , new Location(x + Radius, y - Radius) },
			};
		}

		void Start()
		{
			
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
		/// Cell click aim;
		/// 1- adding building 
		/// 2- for search the cells 
		/// 3- choose the cells for some kind of information
		/// </summary>
		private void OnMouseDown()
		{
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
