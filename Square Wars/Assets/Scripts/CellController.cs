using PaperGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Linq;

public class CellController : MonoBehaviour
{
	public int Size;
	private Cell[][] cells = null;
	public Cell[][] Cells{ get{return cells;}}
	private static readonly Location InitialLocation = new Location(0, 0);
	void Start()
    {
		// @Engin : for two dimensional Cell definition also we can use Cell[,] , but with this definition we do not use Linq methods.
		if (cells == null)
		{
			cells = new Cell[Size][];
			for(int i = 0; i < Size; i++)
			{
				cells[i] = new Cell[Size];
			}
		
			var prefab = Resources.Load("Cell") as GameObject;
			for (int i = 0; i < Size; i++)
			{
				for (int j = 0; j < Size; j++)
				{
					Location newCellLoc = new Location(i * 2 * Cell.Radius, j * 2 * Cell.Radius) + InitialLocation;
					var newObject = Instantiate(prefab);
					var newCell = new Cell();
					newCell.Init(newCellLoc, newObject);
					cells[i][j] = newCell;
				}
			}
		}
	}
    private void OnMouseDown() 
    {
        FindObjectOfType<Region>().AddCellToPlayerRegion(GetCell());
    }
    public GameObject GetCell()
    {
        return gameObject;
    }
    public void ChangeCellColor()
    {

    }
}
