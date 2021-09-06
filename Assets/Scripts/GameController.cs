using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject GameOver;
    public static GameController instance;
    private bool paused;

    void Update()
    {
        instance = this;
    }

    public void PauseScreen()
    {
        if (paused)
        {
            paused = false;
            Time.timeScale = 1f;
        }
        else
        {
            paused = true;
            Time.timeScale = 0f;
        }
    }

    public void ShowGameOver()
    {
        GameOver.SetActive(true);
    }
}
