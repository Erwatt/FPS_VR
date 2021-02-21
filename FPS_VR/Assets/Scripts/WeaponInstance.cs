using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInstance : MonoBehaviour
{

    private GameObject weapon;
    public static Vector3 posPlayer;
    
    void Awake()
    {
        if (WeaponSelection.weaponChoice == "Gun")
        {
            weapon= (GameObject) Instantiate(Resources.Load("Gun"),
                new Vector3(36.625f,9.054f,37.341f),
                Quaternion.Euler(0f,90f,0f));
        }
        else if (WeaponSelection.weaponChoice == "Katana")
        {
            weapon=(GameObject) Instantiate(Resources.Load("Katana"),
                new Vector3(36.656f,8.981f,37.325f),
                Quaternion.Euler(0f,91.16f,90f));
        }

        posPlayer = gameObject.transform.position;

    }
}
