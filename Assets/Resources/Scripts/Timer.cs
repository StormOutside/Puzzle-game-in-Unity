using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text minuteText;
    public Text secondText;
    public float miliSecond;
    public float second;
    public float minute;
    public float zero = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ShowSeconds()
    {
        secondText.text = second.ToString();
    }
    public void ShowMinutes()
    {
        minuteText.text = minute.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        miliSecond += 0.02f;
        if(miliSecond >= 1)
        {
            second++;
            miliSecond = 0;
        }
        if(second>=60)
        {
            minute++;
            second = 0;
        }

        if (second < 10)
        {
            secondText.text = zero + second.ToString();
        }
        if(second > 9)
        {
            ShowSeconds();
        }

       
       
        if(minute < 10)
        {
            minuteText.text = zero + minute.ToString();
        }
        if(minute > 9)
        {
            ShowMinutes();
        }
       
        


    }
}
