using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    MeshRenderer doorMesh;
    BoxCollider landingCollider;

    void Start()
    {
        doorMesh = GetComponent<MeshRenderer>();
        landingCollider = GetComponent<BoxCollider>();    
    }

    public void DoorOpen()
    {
        if(doorMesh.enabled == true || landingCollider.enabled == true )
        {
            doorMesh.enabled = false;
            landingCollider.enabled = false;
        }
    }
}
