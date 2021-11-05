using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playback : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
         //    audioSource.Play();
        //}
    }

    // Update is called once per frame
     private void OnFire()
    {
        audioSource.Play();
    }
    void OnPlayAudio()
    {
        audioSource.Play();
    }
}
