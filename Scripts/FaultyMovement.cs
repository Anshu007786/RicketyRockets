using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaultyMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotationSpeed = 200f;

    [Header("Audio")]
    [SerializeField] AudioClip flyingAudioClip;

    [Header("Particles")]
    [SerializeField] ParticleSystem jetThrusterParticle;
    [SerializeField] ParticleSystem leftThrusterParticle;
    
    Rigidbody rb;
    AudioSource audioSource;

    public bool isFMRunning = true;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotate();
        SoundOnPause();
    }

    void SoundOnPause()
    {
        if (PauseMenu.isPaused)
        {
            audioSource.volume = 0f;
        }
        else
        {
            audioSource.volume = 0.15f;
        }
    }

    void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            StartThrusting();
        }
        else
        {
            StopThrusting();
        }
    }

    void ProcessRotate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            RotateClockwise();
        }

        else
        {
            StopRotationParticles();
        }
    }


    void StartThrusting()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(flyingAudioClip);
        }
        if (!jetThrusterParticle.isPlaying)
        {
            jetThrusterParticle.Play();
        }
    }

    void StopThrusting()
    {
        jetThrusterParticle.Stop();
        audioSource.Stop();
    }

    void RotateClockwise()
    {
        ApplyRotation((-rotationSpeed));
        if (!leftThrusterParticle.isPlaying)
        {
            leftThrusterParticle.Play();
        }
    }
    
    void StopRotationParticles()
    {
        leftThrusterParticle.Stop();
    }


    void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
