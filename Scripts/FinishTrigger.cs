using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    MeshRenderer landingMesh;
    BoxCollider landingCollider;

    void Start()
    {
        landingMesh = GetComponent<MeshRenderer>();
        landingCollider = GetComponent<BoxCollider>();

        landingCollider.enabled = false;
        landingMesh.enabled = false;

    }

    public void ShowUp()
    {
        if(landingMesh.enabled == false || landingCollider.enabled == false )
        {
            landingMesh.enabled = true;
            landingCollider.enabled = true;
        }
        
    }
}
