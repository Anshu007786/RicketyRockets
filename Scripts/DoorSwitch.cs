using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    [SerializeField] Door door;

   
    void Satrt()
    {
        door = GetComponent<Door>();
    }

    void OnTriggerEnter(Collider other)
    {
        door.DoorOpen();
        Destroy(gameObject);
    }
}
