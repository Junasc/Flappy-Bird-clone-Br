using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DontDestroyThis : MonoBehaviour
{
    public AudioSource soundStart;
    void Start()
    {
        DontDestroyOnLoad (soundStart);
    }
}