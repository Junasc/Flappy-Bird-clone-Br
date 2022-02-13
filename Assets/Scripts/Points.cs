using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameController controller;

    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.layer == 7)
        {
            controller.Score++;
            controller.ScoreText.text = controller.Score.ToString();
            controller.ScoreTextUI.text = controller.Score.ToString();
        }
    }
}
