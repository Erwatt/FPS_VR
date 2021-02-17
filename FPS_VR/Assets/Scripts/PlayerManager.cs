using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerStat stat;

    [SerializeField] private TextMeshProUGUI killCounting;

    [SerializeField] private Image showedHealth;
    // Start is called before the first frame update
    void Start()
    {
        killCounting.text = "Kill count : 0";
        stat.killCount = 0;
        showedHealth.fillAmount = 1;
        stat.Life = 100;
    }

    // Update is called once per frame
    void Update()
    {
        killCounting.text = "Kill count :" + stat.killCount;
        showedHealth.fillAmount = stat.Life / 100;
        if (stat.Life <= 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
