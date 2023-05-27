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
                gameOverScreen.SetActive(true);
                Time.timeScale = 0;
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

}
