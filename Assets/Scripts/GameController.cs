using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class GameController : MonoBehaviour
{
    public GameObject GameOver;
    public static GameController instance;
    public string levelName;
    public int Score;
    public Text ScoreText;
    public Text ScoreTextUI;
    private bool paused;

    void Start()
    {
        Time.timeScale = 1f; //para qnd reiniciar o jogo ele despausar
    }
    void Update()
    {
        instance = this;
        Scene scene = SceneManager.GetActiveScene();
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
    public void RestartGame(string levelName)
    {
        SceneManager.LoadScene(levelName); 
    }
}
