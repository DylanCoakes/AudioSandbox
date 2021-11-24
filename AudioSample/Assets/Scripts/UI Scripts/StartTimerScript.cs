using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTimerScript : MonoBehaviour
{
    [SerializeField]
    private Text uiText;
    [SerializeField]
    //max time counting down from
    private float mainTimer;

    private float timer;
    private bool canCOunt = true;
    private bool doOnce = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (timer ?=0.0f ) 
    }
}
