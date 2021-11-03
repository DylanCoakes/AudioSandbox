using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapShotCollider : MonoBehaviour

{
    public AudioMixerSnapshot DAY;
    public AudioMixerSnapshot RANDOM;

// Start is called before the first frame update
    void Start()
    {
        
    }
        bool isRANDOM = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!isRANDOM)
            {
                 RANDOM.TransitionTo(0.5f);
                isRANDOM = true;
            }
            else if (isRANDOM)
            {
                DAY.TransitionTo(0.5f);
                isRANDOM = false;
            }
           
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
