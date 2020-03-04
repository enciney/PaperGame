using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] Canvas startingMenuCanvas;
    [SerializeField] Canvas mainMenuCanvas;
    public void ActiveStartingMenuCanvas()
    {
        mainMenuCanvas.gameObject.SetActive(false);
        startingMenuCanvas.gameObject.SetActive(true);
    }
    public void DeactiveStartingMenuCanvas()
    {
        startingMenuCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(true);
    }
}
