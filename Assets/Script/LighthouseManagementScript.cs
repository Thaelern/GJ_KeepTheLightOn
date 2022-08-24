using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighthouseManagementScript : MonoBehaviour
{
    [SerializeField]
    private int currentPowerLevels;
    [SerializeField]
    private int SecondsBetweenPowerLowering;

    private int MaxPowerLevels;

   

    private void Start()
    {
        MaxPowerLevels = 100;
    }



    public void RefillPower()
    {
        currentPowerLevels = MaxPowerLevels;
        StartCoroutine(LinearLowerPowerLevels());
        
    }


   IEnumerator LinearLowerPowerLevels()
    {
        while (currentPowerLevels >= 0)
        {
            yield return new WaitForSeconds(SecondsBetweenPowerLowering);
            currentPowerLevels = currentPowerLevels - 1;
        }
        
    }
}
