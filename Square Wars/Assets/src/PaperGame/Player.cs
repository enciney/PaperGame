using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PaperGame
{
	public class Player : MonoBehaviour
	{
		
		public List<List<Cell>> UserCells { get { return userCells; } }
		public bool IsUser { get { return isUser; } }
		public Color Color { get { return color; } }
		public List<IBuilding> Buildings { get { return buildings; } }

		private List<List<Cell>> userCells;
		private bool isUser;
		private Color color;
		private List<IBuilding> buildings;

		public void Init(List<Cell> list, Color color, bool isUser = false )
		{
			UserCellInitialization(list);
			this.isUser = isUser;
			this.color = color;
			buildings = new List<IBuilding>();
		}

		private void UserCellInitialization(List<Cell> list)
		{
			var initialUserCellLenght = GameBoard.initialUserCellLenght;
			userCells = new List<List<Cell>>();
			var size = list.Count;
			for (int i = 0; i < size; i++)
			{
				if (i % initialUserCellLenght == 0)
				{
					userCells.Add(new List<Cell>());
				}

				userCells[(int)(i / initialUserCellLenght)].Add(list.ElementAt(i));
			}
		}

		/// <summary>
		/// addBuilding to cell
		/// </summary>
		/// <param name="build"></param>
		public void AddBuilding(IBuilding build)
		{
			buildings.Add(build);
			
		}


	}
}
