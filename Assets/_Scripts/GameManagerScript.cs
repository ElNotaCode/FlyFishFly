using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{

    public GameObject gameOverScreen;
    private bool fishIsAlive = true;
    private float timer = 0;
    public float gameOverDelay;
    public Text textScore;
    private int score = 0;
    private bool oneTime = true;

    [SerializeField] private InterstitialAdScript intesticialAdScript;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (!fishIsAlive)
        {
            if (timer > gameOverDelay)
            {
                if (oneTime)
                {
                    GameOverAdScreen();
                    oneTime = false;
                }
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0.5f;
        fishIsAlive = false;
    }

    public void IncreaseScore()
    {
        score++;
        textScore.text = score.ToString();
    }

    private void GameOverAdScreen()
    {
        if (!PlayerPrefs.HasKey("adCounter"))
        {
            PlayerPrefs.SetInt("adCounter", 3);
        }

        gameOverScreen.SetActive(true);
        Time.timeScale = 0;

        PlayerPrefs.SetInt("adCounter", (PlayerPrefs.GetInt("adCounter") - 1));

        if (PlayerPrefs.GetInt("adCounter") <= 0)
        {
            intesticialAdScript.ShowAd();
            PlayerPrefs.SetInt("adCounter", 4);
        }
    }

}
