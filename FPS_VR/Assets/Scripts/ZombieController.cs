using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent zombie;
    [SerializeField] private Animator animZombie;
    
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

        if (Vector3.Distance(WeaponInstance.posPlayer, zombie.transform.position) > 0.5)
        {
            animZombie.SetBool("nearPlayer",false);
            zombie.SetDestination(WeaponInstance.posPlayer);
        }
        else
        {
            animZombie.SetBool("nearPlayer",true);
        }
    }
}
