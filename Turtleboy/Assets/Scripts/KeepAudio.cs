using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudio : MonoBehaviour
{
    public GameObject backgroundMusic;
    void Awake()
    {
        if(GameObject.FindGameObjectWithTag("BackgroundMusic") == null)
        {
            Instantiate(backgroundMusic);
            DontDestroyOnLoad(transform.gameObject);
        }
        
    }
}
