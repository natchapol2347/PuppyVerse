using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerGameoverLogic : MonoBehaviour
{

    // Start is called before the first frame update

    int countDownStartValue = 90;
    public TMP_Text timerUI;
    void Start()
    {
        counDownTimer();
    }

    void counDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            if (spanTime.Seconds < 10)
            {
                timerUI.text = "Timer: " + spanTime.Minutes + ":0" + spanTime.Seconds;
            }
            else { 
                timerUI.text = "Timer: " + spanTime.Minutes + ":" + spanTime.Seconds; 
            }
            countDownStartValue--;
            Invoke("counDownTimer", 1.0f);
        }

        else
        {
            timerUI.text = "GameOver!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
