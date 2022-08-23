using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceScript : MonoBehaviour
{

    // variables
    private bool isPlayerinrange;


    // variable end.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerinrange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerinrange = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            RefillFurnace();
        }
    }

    private void RefillFurnace()
    {
        if (isPlayerinrange)
        {
            Debug.Log("Furnace has been refilled");
        }
        
    }
}
