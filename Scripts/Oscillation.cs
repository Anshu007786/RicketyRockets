using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillation : MonoBehaviour
{
    Vector3 startingPos;
    [SerializeField] Vector3 movementVector;
    [SerializeField] [Range(0,1)] float movementFactor;
    [SerializeField] float period = 2f;

    void Start()
    {
        startingPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(period <= Mathf.Epsilon) { return ; }

        const float tau = Mathf.PI * 2;

        float cycles = Time.time / period;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWave + 1f) / 2f;

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPos + offset;
        
    }
}
