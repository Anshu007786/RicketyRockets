using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugKeys : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("Escape Hit");
        }
    }
}
