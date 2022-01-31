using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSound : MonoBehaviour
{
    public GameObject sound;
    private bool PausedSound;
    void Start()
    {
        AudioListener.pause = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PausedSound = !PausedSound;
            AudioListener.pause = PausedSound;
        }
    }
}
