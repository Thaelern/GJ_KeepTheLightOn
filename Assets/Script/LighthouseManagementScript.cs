using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighthouseManagementScript : MonoBehaviour
{
    [SerializeField]
    private int currentPowerLevels;

    private int MaxPowerLevels;

   

    private void Start()
    {
        MaxPowerLevels = 100;
    }



    public void RefillPower()
    {
        currentPowerLevels = MaxPowerLevels;
    }

}
