using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectInteraction : MonoBehaviour
{
    public GameManager gameManager; // Αναφορά στο GameManager
    public bool isWinObject = false; // Αν το αντικείμενο είναι το "Win" αντικείμενο

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Object Activated!");

            if (isWinObject)
            {
                gameManager.WinGame(); 
            }
            else
            {
                gameManager.ActivateObject(); 
            }

            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}