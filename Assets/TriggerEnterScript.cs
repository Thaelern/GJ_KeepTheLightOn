using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterScript : MonoBehaviour
{


    [SerializeField]
    private bool ButtonActivated;

    [SerializeField]
    private bool PlayerInRange = false;

    [SerializeField]
    private GameObject ObjectToManipulate;
    [SerializeField]
    private GameObject Light;

    public int rotationSpeed;

    [SerializeField]
    private int LightMaxIntensity;
    [SerializeField]
    private int LightCurrentIntensity;

    private void Start()
    {
        Light.SetActive(true);
    }

   private void Update()
    {

        // listens for whether to activate device

        if (Input.GetKeyDown(KeyCode.F))
        {
            ActivateDevice();
            LightCurrentIntensity = LightMaxIntensity;
            StartCoroutine(ChangeLightIntensity());
        }


        // continueiously rotates object while bool true
        if (ButtonActivated == true)
        {
            RotateAroundZ();
        }

        else
        {
            DisableDevice();
        }
        
    }
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered zone");
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInRange = false;
        }
    }

    private void ActivateDevice()
    {
        if (PlayerInRange == true)
        {
            ButtonActivated = !ButtonActivated;
        }
        else return;
        
    }

    private void RotateAroundZ()
    {
        Light.SetActive(true);
        ObjectToManipulate.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void DisableDevice()
    {
        Light.SetActive(false);
        ButtonActivated = false;

    }


    // disables the light after 3 seconds.
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("Three seconds has passed. Attempting to turn off lights");
        DisableDevice();
    }

    // changes the valuoe of the light --1 every second.
    IEnumerator ChangeLightIntensity()
    {
        while (LightCurrentIntensity >= 0)
        {
            Debug.Log("Tick");
            yield return new WaitForSeconds(1);
            Light.GetComponent<Light>().intensity = LightCurrentIntensity;
            LightCurrentIntensity = LightCurrentIntensity - 1;
        }

    }
}
