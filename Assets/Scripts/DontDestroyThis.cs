using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class DontDestroyThis : MonoBehaviour
{
    public AudioSource soundStart;

    void Start()
    {
        DontDestroyOnLoad(soundStart);   
    }
    
}
