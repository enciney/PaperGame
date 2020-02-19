using PaperGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class CellController : MonoBehaviour
{
	private static List<Cell> selectedCells = new List<Cell>();
	public int Size;
	public GameObject cellPrefab;
	public string userStartCorner;
	private Corner userCorner;
	private Cell[][] cells = null;
	public Cell[][] Cells{ get{return cells;}}
	
	void Start()
    {
		if(!Enum.TryParse<Corner>(userStartCorner, true, out userCorner))
		{
			// invalid string for corner
		}
		var gameBoard = new GameBoard();
		gameBoard.CreateBoard(Size, userCorner);
		
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
