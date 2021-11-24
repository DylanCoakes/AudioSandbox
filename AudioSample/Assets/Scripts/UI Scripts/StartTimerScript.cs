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
    private bool canCount = true;
    private bool doOnce = false;

    private void Start()
    {//the timer is what we set it in the inspector
        timer = mainTimer;
    }

    // Update is called once per frame
    void Update()
    {
       if (timer >=0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("f");

        }
       else if (timer <= 0.0 && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.00f;
        }
    }
    //once the button is pressed, reset the timer.
    public void resetButton()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
    }
}

