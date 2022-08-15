using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float nextSceneLoadWaitTime = 0.3f;
    [Header("Audio")]
    [SerializeField] AudioClip crashingAudio;
    [SerializeField] AudioClip victoryAudio;
    
    [Header("Particle Effect")]
    [SerializeField] ParticleSystem crashingParticles;
    [SerializeField] ParticleSystem victoryParticles;

    AudioSource audioSource;
    //ParticleSystem particle;

    bool isTransitioning = false;
    bool collisionDisable = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(isTransitioning || collisionDisable) { return; } 
        
        switch (other.gameObject.tag)
        {
            case "Finish":   
                NextLevelSequence();
                break;
            case "Friendly":   
                break;   
            case "Button":   
                break;    
            default:
                StartCrashSequence();
                break;
        }    
    }

    void StartCrashSequence()
    { 
        isTransitioning = true;
        audioSource.Stop();
        crashingParticles.Play();
        audioSource.PlayOneShot(crashingAudio);
        GetComponent<Movement>().enabled = false;
        Invoke("SceneReload", nextSceneLoadWaitTime);
    }

    void NextLevelSequence()
    {
        isTransitioning = true;
        audioSource.Stop();
        victoryParticles.Play();
        audioSource.PlayOneShot(victoryAudio);
        GetComponent<Movement>().enabled = false;
        Invoke ("LoadNextLevel" , nextSceneLoadWaitTime);
        
    }

    void SceneReload()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1; 
        if(nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
