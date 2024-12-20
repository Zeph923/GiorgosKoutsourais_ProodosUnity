using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectInteraction : MonoBehaviour
{
    public GameManager gameManager; // ������� ��� GameManager
    public bool isWinObject = false; // �� �� ����������� ����� �� "Win" �����������

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