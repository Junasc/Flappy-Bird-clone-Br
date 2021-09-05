using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLogs : MonoBehaviour
{
    public GameObject Logs;
    public float height; //altura maxima da toras na cena
    public float maxTime = 1f; //intervalo entre aparecimento
    private float timer = 0f;

    void Start()
    {
        GameObject newLogs = Instantiate(Logs);
        newLogs.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
       if(timer > maxTime){
        GameObject newLogs = Instantiate(Logs);
        newLogs.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newLogs, 20f); //destruir toras que já passaram
        timer = 0;
       }
       timer += Time.deltaTime;
    }
}
