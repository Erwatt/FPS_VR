using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    

    [SerializeField] private NavMeshAgent zombie;
    [SerializeField] private Animator animZombie;
    [SerializeField] private ZombieStat zombieStat;
    [SerializeField] private PlayerStat playerStat;

    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        zombieStat.zLife = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(WeaponInstance.posPlayer, zombie.transform.position) < 10)
        {
            Vector3 direction = WeaponInstance.posPlayer - zombie.transform.position;
            
            zombie.transform.rotation = Quaternion.Slerp(zombie.transform.rotation, Quaternion.LookRotation(direction),0.1f);
        }

        if (Vector3.Distance(WeaponInstance.posPlayer, zombie.transform.position) >= 1f)
        {
            animZombie.SetBool("nearPlayer",false);
            zombie.SetDestination(WeaponInstance.posPlayer);
        }
        else
        {
            animZombie.SetBool("nearPlayer",true);
        }

        if (animZombie.GetBool("nearPlayer") == true)
        {
            attackController();
        }
    }

    //private void OnTriggerEnter(Collider other)
     //   {
     //       Debug.Log("prout");
            //Destroy(other.gameObject);
     //   }

     private void attackController()
     {
         const float attackDelay = 3f;
         
        if (timer > attackDelay)
        {
            animZombie.SetBool("attack",true);
            playerStat.Life -= zombieStat.zDamage;
            timer = 0f;
        }

         timer += Time.deltaTime;
         
     }
}
