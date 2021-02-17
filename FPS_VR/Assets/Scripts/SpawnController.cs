using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject ennemy;
    private Vector3 posSpawner;

    private const float spawnDelay = 20f; //temps en secondes au bout de laquelle une nouvelle cible va appraître
    private float timer = 0f; //temps qui va être comparé au spawnDelay, dès qu'il va l'atteindre : instanciation d'une nouvelle cible
    
    
    void Start()
    {
        posSpawner = transform.position;
        Instantiate(Resources.Load("Zombie"),
            posSpawner,
            Quaternion.identity).name="Zombie";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnDelay)
        {
            Instantiate(Resources.Load("Zombie"),
                posSpawner,
                Quaternion.identity).name="Zombie";
            timer = 0;
        }
    }
}
