using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnaceScript : MonoBehaviour
{

    // variables
    private bool isPlayerinrange;





    [SerializeField]
    private float currentFuel;

    public GameObject LightHouseManagement;




    // variable end.


    private void Start()
    {
        currentFuel = 180f;
    }


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
            Debug.Log("ENTER");
            RefillFurnace();
        }
    }

    private void RefillFurnace()
    {
        if (isPlayerinrange)
        {
            Debug.Log("Furnace has been refilled");
            // this is super dirty and criminal. Refactor by casting to a permanent variable set at the start.
            LightHouseManagement.GetComponent<LighthouseManagementScript>().RefillPower();
        }

    }
}
