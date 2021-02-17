using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    private float timer;

    private void Update()
    {
        waitTillRestart();
    }

    private void waitTillRestart()
    {
        const float restartTime = 10f;
        if (timer > restartTime)
        {
            SceneManager.LoadScene("Menu");
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
