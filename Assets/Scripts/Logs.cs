using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logs : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        // atribui a posição desse objeto a cada frame
        // vector3 sempre tem -1 no x, ou seja, smp vai para esquerda
        // speed para controlar velocidade que ele aparece
        // delta time para ele não chegar de vez
    }
}
