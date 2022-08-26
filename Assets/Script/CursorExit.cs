using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorExit : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
