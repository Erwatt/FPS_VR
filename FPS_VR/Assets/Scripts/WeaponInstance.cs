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
                new Vector3(35.90586f,8.312f,37.76f),
                Quaternion.identity);
        }
        else if (WeaponSelection.weaponChoice == "Katana")
        {
            weapon=(GameObject) Instantiate(Resources.Load("Katana"),
                new Vector3(36.493f,8.878f,36.761f),
                Quaternion.identity);
        }

        posPlayer = gameObject.transform.position;

    }
}
