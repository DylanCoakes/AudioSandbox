using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class SnapshotManager : MonoBehaviour
{
    public AudioMixerSnapshot day;
        public AudioMixerSnapshot night;

    public float transitionTime = 2;

    //public AudioMixer ambience;
        //public AudioMixerGroup birds;
    // Start is called before the first frame update
    void Start()
    {
       // Player = GetComponent<PlayerInput>();
    }
     void OnPlayAudio()
    {
        night.TransitionTo(transitionTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
