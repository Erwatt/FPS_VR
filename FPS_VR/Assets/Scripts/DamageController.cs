using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private PlayerStat stat;
    [SerializeField] private ZombieStat zstat;
    [SerializeField] private AudioClip sliceClip;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip deathClip;
    //private float timer;

    //[SerializeField] private int weaponDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //const float damageDelay = 0f;
        //if (timer > damageDelay)
        //{
        if (WeaponSelection.weaponChoice == "Gun")
        {
            
            other.gameObject.GetComponent<ZombieController>().zombieLife -= stat.gunDMG;
            source.PlayOneShot(sliceClip);
        }
        else if (WeaponSelection.weaponChoice == "Katana")
        {
            other.gameObject.GetComponent<ZombieController>().zombieLife -= stat.swordDMG;
            source.PlayOneShot(sliceClip);
        }
        if (other.gameObject.GetComponent<ZombieController>().zombieLife <= 0)
        {
            Destroy(other.gameObject);
            source.PlayOneShot(deathClip);
            stat.killCount += 1;
        }

        //timer = 0;
        //}

        //timer += Time.deltaTime;
    }
}
