using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSound : MonoBehaviour
{
    private bool PausedSound;
    public GameObject buttonSound;
    void Start()
    {
        AudioListener.pause = false;
    }
     public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100.0f))
            {
               if(hit.transform != null)
               {
                   Rigidbody rb;

                   if(rb = hit.transform.GetComponent<Rigidbody>())
                   {
                       Debug.Log("cliquei");
                   }
               }
            }
            PausedSound = !PausedSound;
            AudioListener.pause = PausedSound;
        }
    }
}