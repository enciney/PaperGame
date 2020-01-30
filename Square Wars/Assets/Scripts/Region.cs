using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour
{
    [SerializeField] List<GameObject> region = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Build()
    {
        
    }
    public void AddCellToPlayerRegion(GameObject selectedCell)
    {
        if(!region.Contains(selectedCell))
        {
            Select(selectedCell);
            
        }
        else
        {
            Deselect(selectedCell);
        }
    }

    private void Select(GameObject selectedCell)
    {
        region.Add(selectedCell);
        foreach (var cells in region)
        {
            cells.GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void Deselect(GameObject selectedCell)
    {
        selectedCell.GetComponent<SpriteRenderer>().color = Color.white;
        region.Remove(selectedCell);
    }

    public void CompleteTakeover()
    {

    }
}
