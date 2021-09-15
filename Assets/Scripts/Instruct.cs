using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instrucao : MonoBehaviour
{
    public Text txt;
    public string texto;

    void Start()
    {
        StartCoroutine(frase (texto));

    }

    IEnumerator frase (string frase)
    {
        int letra = 0;
        txt.text = "";
        while (letra< frase.Length) 
        {
            txt.text += frase [letra];
            letra += 1;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
