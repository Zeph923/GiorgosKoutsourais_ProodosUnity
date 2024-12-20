using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalObjects = 10; 
    private int activatedObjects = 0; 

    public void WinGame()
    {
        Debug.Log("You Win!");
    }

    public void ActivateObject()
    {
        activatedObjects++;
        Debug.Log("Activated Objects: " + activatedObjects);

        if (activatedObjects == totalObjects)
        {
            Debug.Log("All Objects Activated!");
        }
    }
}
