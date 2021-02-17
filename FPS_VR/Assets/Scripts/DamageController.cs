using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private PlayerStat stat;
    [SerializeField] private ZombieStat zstat;
    [SerializeField] private AudioSource sliceSource;
    [SerializeField] private AudioClip sliceClip;
    [SerializeField] private AudioSource deathSource;
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
            zstat.zLife -= stat.gunDMG;
        }
        else if (WeaponSelection.weaponChoice == "Katana")
        {
            zstat.zLife -= stat.swordDMG;
            sliceSource.PlayOneShot(sliceClip);
        }
        if (zstat.zLife <= 0)
        {
            Destroy(other.gameObject);
            deathSource.PlayOneShot(deathClip);
            stat.killCount += 1;
        }

        //timer = 0;
        //}

        //timer += Time.deltaTime;
    }
}
