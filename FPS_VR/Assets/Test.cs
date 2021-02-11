using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    void Awake()
    {
        SceneManager.LoadScene("MoodyNight");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("MoodyNight"));
        Debug.Log(SceneManager.GetActiveScene().name);
    }

    
}
