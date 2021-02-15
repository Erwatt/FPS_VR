using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    [SerializeField] private Transform playerPos;

    [SerializeField] private NavMeshAgent zombie;
    [SerializeField] private Animator animZombie;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(playerPos.position, zombie.transform.position) < 10)
        {
            Vector3 direction = playerPos.position - zombie.transform.position;
            
            zombie.transform.rotation = Quaternion.Slerp(zombie.transform.rotation, Quaternion.LookRotation(direction),0.1f);
        }

        if (Vector3.Distance(playerPos.position, zombie.transform.position) > 0.5)
        {
            animZombie.SetBool("nearPlayer",false);
            zombie.SetDestination(playerPos.position);
        }
        else
        {
            animZombie.SetBool("nearPlayer",true);
        }
    }
}
