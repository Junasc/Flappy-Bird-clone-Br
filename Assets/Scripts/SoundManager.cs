using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SoundManager : MonoBehaviour
{
    public GameController controller;
    public GameObject sound;
    private bool PausedSound;

    void Start()
    {
         GameObject audioSourceGameObject = GameObject.Find("sound");
          AudioSource source = audioSourceGameObject.GetComponent<AudioSource>();
          if(SceneManager.GetActiveScene().name == "cenaPrincipal")
          {
            source.Stop(); 
          }
    }
}
