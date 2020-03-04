using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingSettings : MonoBehaviour
{
    public static StartingSettings instance = null;
    [SerializeField] private Color playerColor;
    public Color PlayerColor
    {
        get { return playerColor; }
        set { playerColor = value; }
    }
    private void Awake() 
    {
      if (instance == null)
      {
        instance = this;
        DontDestroyOnLoad(gameObject);
      }
      else if (instance != this)
      {
        Destroy(gameObject);
      }   
    }
}
