using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ColorBox : MonoBehaviour
{
    private Color boxColor;
    public Color BoxColor
    {
        get { return boxColor; }
        set { boxColor = value; }
    }
    private void Start() 
    {
        boxColor = GetComponent<Image>().color;
    }
    public void SetPlayerColor()
    {
        FindObjectOfType<StartingSettings>().PlayerColor = boxColor;
    }
}
