using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInstance : MonoBehaviour
{

    private GameObject weapon;
    
    void Awake()
    {
        Debug.Log(WeaponSelection.weaponChoice);
        if (WeaponSelection.weaponChoice == "Gun")
        {
            weapon= (GameObject) Instantiate(Resources.Load("Gun"));
        }
        else if (WeaponSelection.weaponChoice == "Katana")
        {
            weapon=(GameObject) Instantiate(Resources.Load("Katana"),
                new Vector3(36.493f,8.878f,36.761f),
                Quaternion.identity);
        }
    }
}
