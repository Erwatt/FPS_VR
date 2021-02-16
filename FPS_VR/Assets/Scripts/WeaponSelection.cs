using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelection : MonoBehaviour
{
    //[SerializeField] private static GameObject weaponChoice;
    public static string weaponChoice;
    public void HandleClick(GameObject weapon)
    {
        
        
        SceneManager.LoadScene("MoodyNight");
        weaponChoice = weapon.name;

    }
    

}
