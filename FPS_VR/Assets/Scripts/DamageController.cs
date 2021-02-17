using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private PlayerStat stat;
    [SerializeField] private ZombieStat zstat;
    private float timer;

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
            zstat.zLife -= stat.swordDMG;
            if (zstat.zLife <= 0)
            {
                Destroy(other.gameObject);
                stat.killCount += 1;
            }

            timer = 0;
        //}

        //timer += Time.deltaTime;
    }
}
