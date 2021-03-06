using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
        
    }

    public void Fire()
    {
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().AddForce( barrel.forward * speed);
        audioSource.PlayOneShot(audioClip);
        Destroy(spawnedBullet,2);
    }
    
}
