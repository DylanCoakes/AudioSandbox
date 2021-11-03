using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource triggerAudio;

    private void OnTriggerEnter(Collider other)
    {
        triggerAudio.Play();
    }




}