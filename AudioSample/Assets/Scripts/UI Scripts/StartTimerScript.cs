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
    {//the timer is what is set in the inspector
        timer = mainTimer;
    }

    // Update is called once per frame
    void Update()
    {//if the time is bellow or = to 0 count down 
       if (timer >=0.0f && canCount)
        {//countdown in real time
            timer -= Time.deltaTime;
            //makes the time apear as text in unity//converts numbers to letters
            uiText.text = timer.ToString("f");

        }//once value is less than 0/ set these values
       else if (timer <= 0.0 && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.00f;
        }
    }
    //once the button is pressed, set the new value to reset the timer.
    public void resetButton()
    {
        timer = mainTimer;
        canCount = true;
        doOnce = false;
    }
}

