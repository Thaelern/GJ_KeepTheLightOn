using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{

    public GameObject FtoInteract;
    bool hintSeen;

    private void OnTriggerEnter(Collider other)
    {
        if(!hintSeen && other.tag == "Player")
        {
            FtoInteract.SetActive(true);
            hintSeen = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        FtoInteract.SetActive(false);
    }
}
