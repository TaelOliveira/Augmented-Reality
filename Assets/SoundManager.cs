using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource soundSource;
    
    void Awake()
    {
        instance = this;
    }

    public void PlaySingle(AudioClip clip){
        
        soundSource.clip = clip;
        soundSource.Play();
    }

}