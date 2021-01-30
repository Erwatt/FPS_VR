using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSaber : MonoBehaviour
{

    private AudioSource audioSource;
    private Animator animator;
    private AudioClip beamAudio;

    
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
       
    }


    
    public void TriggerBeam()
    {
        bool isOn = animator.GetBool("LightSaberOn");
        if (!isOn)
        {
            audioSource.PlayOneShot(beamAudio);
        }
        else
        {
            audioSource.Stop();
        }
        animator.SetBool("LightSaberOn", !isOn);
    }
}
