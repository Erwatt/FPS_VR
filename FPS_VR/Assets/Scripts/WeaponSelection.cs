using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponSelection : MonoBehaviour
{
    //[SerializeField] private static GameObject weaponChoice;
    public GameObject weapon;
    public void HandleClick(GameObject weaponChoice)
    {
        
        if (weaponChoice.name == "Gun")
        {
            weapon=(GameObject) Instantiate(Resources.Load("Gun"));
        }
        else if (weaponChoice.name == "Katana")
        {
            weapon=(GameObject) Instantiate(Resources.Load("Katana"),
                new Vector3(36.493f,8.878f,36.761f),
                Quaternion.identity);
        }
        DontDestroyOnLoad(weapon);
        SceneManager.LoadScene("Moody Night");
        
    }
    

}
