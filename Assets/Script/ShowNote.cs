using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNote : MonoBehaviour
{

    public GameObject InstructionNote;
    public GameObject EToRead;
    public GameObject player;
    //public GameObject exitButton;
    public bool inReach, noteOpen;

    private void Update()
    {
        if (inReach)
        {

            if (!noteOpen && Input.GetKeyDown(KeyCode.E))
            {
                EToRead.SetActive(false);
                InstructionNote.SetActive(true);
                Time.timeScale = 0;
                noteOpen = true;
            }

            else if (noteOpen && Input.GetKeyDown(KeyCode.E))
            {
                InstructionNote.SetActive(false);
                Time.timeScale = 1;
                EToRead.SetActive(true);
                noteOpen = false;
            }
        }



    }


    private void OnTriggerEnter(Collider other)
    {
        EToRead.SetActive(true);
        inReach = true;
    }

    private void OnTriggerExit(Collider other)
    {
        EToRead.SetActive(false);
        inReach = false;
    }


}
