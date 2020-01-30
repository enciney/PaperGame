using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
