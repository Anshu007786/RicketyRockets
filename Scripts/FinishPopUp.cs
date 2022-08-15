using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPopUp : MonoBehaviour
{
    [SerializeField] FinishTrigger finishTrigger;

    void Satrt()
    {
        finishTrigger = GetComponent<FinishTrigger>();
    }
    void OnTriggerEnter(Collider other)
    {
            finishTrigger.ShowUp();
            Destroy(gameObject);
    }
}
