using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent zombie;
    [SerializeField] private Animator animZombie;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
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

        if (animZombie.GetBool("nearPlayer"))
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
            Debug.Log("player takes damage");
            timer = 0f;
        }

        timer += Time.deltaTime;
         
    }
}
