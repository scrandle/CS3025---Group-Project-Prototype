using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hail : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void play()
    {
        audioSource.Play();
    }
    
}
