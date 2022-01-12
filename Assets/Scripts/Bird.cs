using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public static Bird instance;

    public float speed = 1f;

    private AudioSource soundFlappy;

    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        soundFlappy = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            soundFlappy.Play();
            rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            GameController.instance.PauseScreen();
            AudioListener.pause = true;

            //Destroy(soundFlappy);
            GameController.instance.ShowGameOver();
        }
    }
}
