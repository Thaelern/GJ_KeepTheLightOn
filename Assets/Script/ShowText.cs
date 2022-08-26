using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{

    public GameObject FtoInteract;
    bool hintSeen;
    int hintSeenTimes;

    private void Start()
    {
        hintSeenTimes = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(hintSeenTimes<=3 && other.tag=="Player")
        {
            FtoInteract.SetActive(true);
            hintSeenTimes++;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        FtoInteract.SetActive(false);
    }
}
