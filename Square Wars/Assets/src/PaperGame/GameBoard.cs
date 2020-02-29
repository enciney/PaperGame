using System;
using PaperGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace PaperGame
{
	public class GameBoard : MonoBehaviour
	{
		public Color defaultCellColor = Color.gray;
		public const int userCellLenght = 3;
		private int boardWidth;
		private int boardHeight;
		private Cell[][] cells = null;
		public Cell[][] Cells { get { return cells; } }
		public Cell[][] UserCells { get { return userCells; } }
		private Cell[][] userCells;

		public static readonly Location InitialLocation = new Location(0, 0);

		public void CreateBoard(int size, Corner userCorner) => CreateBoard(size, size, userCorner);
		
		public void CreateBoard(int width, int height, Corner userCorner)
		{
			userCells = new Cell[userCellLenght][];
			for (int i = 0; i < userCellLenght; i++)
			{
				userCells[i] = new Cell[userCellLenght];
			}

			boardWidth = width;
			boardHeight = height;
			var userBorder = GiveUserBorder(userCorner);
			// @Engin : for two dimensional Cell definition also we can use Cell[,] , but with this definition we do not use Linq methods.
			// singleton
			if (cells == null)
			{
				cells = new Cell[width][];
				for (int i = 0; i < width; i++)
				{
					cells[i] = new Cell[height];
				}

				var prefab = Resources.Load("Cell") as GameObject;
				for (int i = 0; i < width; i++)
				{
					for (int j = 0; j < height; j++)
					{
						var isUserCell = false;
						var cellColor = defaultCellColor;
						Location newCellLoc = new Location(i * 2 * Cell.Radius, j * 2 * Cell.Radius) + InitialLocation;
						var newObject = Instantiate(prefab);
						if ((userBorder.Item1.X <= i && i <= userBorder.Item2.X) && (userBorder.Item1.Y <= j && j <= userBorder.Item2.Y))
						{
							isUserCell = true;
							// https://www.rapidtables.com/web/color/green-color.html
							cellColor = new Color(50, 205, 0); //limegreen
						}
						var newCell = new Cell();
						newCell.Init(newCellLoc, newObject, cellColor);
						if (isUserCell)
						{
							//@TODO need userCell initialization
						}

						cells[i][j] = newCell;
					}
				}
			}
		}

		public Tuple<Location,Location> GiveUserBorder(Corner corner)
		{
			var startLenghtIndex = userCellLenght - 1;
			var height = boardHeight - 1;
			var width = boardWidth - 1;
			switch (corner)
			{
				case Corner.LeftUp:
					return Tuple.Create(new Location(0, height - startLenghtIndex), new Location(startLenghtIndex, height));
				case Corner.LeftDown:
					return Tuple.Create(new Location(0, 0), new Location(startLenghtIndex, startLenghtIndex));
				case Corner.RightUp:
					return Tuple.Create(new Location(width - startLenghtIndex, height - startLenghtIndex), new Location(width, height));
				case Corner.RightDown:
					return Tuple.Create(new Location(width - startLenghtIndex, 0), new Location(width, startLenghtIndex));
				default:
					break;
			}

			return null;
		}
	}
}
