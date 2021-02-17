using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ZombieController : MonoBehaviour
{
    

    [SerializeField] private NavMeshAgent zombie;
    [SerializeField] private Animator animZombie;
    [SerializeField] private ZombieStat zombieStat;
    [SerializeField] private PlayerStat playerStat;
    [SerializeField] private Image zombieHealthBar;

    private float timer;

    public float zombieLife;
    
    // Start is called before the first frame update
    void Start()
    {
        zombieLife = zombieStat.zLife;
        zombieHealthBar.fillAmount = 1;
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

        zombieHealthBar.fillAmount = zombieLife / 100;
    }
    

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
