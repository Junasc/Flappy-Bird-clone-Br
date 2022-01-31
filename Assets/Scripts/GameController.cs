using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject BackgroundDeforested;
    public GameObject BackgroundOnFire;
    public GameObject BackgroundForest;
    public static GameController instance;
    public string levelName;
    public int Score;
    public Text ScoreText;
    public Text ScoreTextUI;
    private bool paused;

    void Start()
    {
        Time.timeScale = 1f; //para qnd reiniciar o jogo ele despausar
        AudioListener.pause = false;
    }

    void Update()
    {
        instance = this;
        Scene scene = SceneManager.GetActiveScene();
        if (Score == 20)
        {
            BackgroundDeforested.SetActive(true);
            BackgroundOnFire.SetActive(false);
        }
        if (Score == 50)
        {
            BackgroundDeforested.SetActive(false);
            BackgroundForest.SetActive(true);
        }
    }

    public void PauseScreen()
    {
        if (paused)
        {
            paused = false;
            Time.timeScale = 1f;
            AudioListener.pause = true;
        }
        else
        {
            paused = true;
            Time.timeScale = 0f;
            AudioListener.pause = false;
        }
    }

    public void ShowGameOver()
    {
        GameOver.SetActive(true);
    }

    public void RestartGame(string levelName)
    {
        SceneManager.LoadScene (levelName);
    }

    public void Exit()
    {
        Application.Quit();
    }
}