using PaperGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
	private readonly Location initialLocation = new Location(0, 40);

	// Start is called before the first frame update
	void Start()
    {
		var prefab = Resources.Load("Cell") as GameObject;
		for (int i = 0; i < 50; i++)
		{
			Location xSquares = new Location(i * Cell.CellRadius, 0);
			//var cell = new Cell(initialLocation + xSquares);

			var newObject = Instantiate(prefab);
			newObject.transform.localScale = new Vector3(2 * Cell.CellRadius, 2 * Cell.CellRadius);
			newObject.transform.position = new Vector3(i * Cell.CellRadius, 0);

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
