using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class countD : MonoBehaviour
{

    public Text timerText;
    float minutes = 3;
    float seconds = 0;
    float milliseconds = 0;

    public Canvas win1;


    void Start()
    {
        
    }

    void Update()
    {

        if (milliseconds <= 0)
        {
            if (seconds <= 0)
            {
                minutes--;
                seconds = 59;
            }
            else if (seconds >= 0)
            {
                seconds--;
            }

            milliseconds = 60;
        }

        milliseconds -= Time.deltaTime * 100;

        //Debug.Log(string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds));
        timerText.text = "TIME "+minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        //    timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

      /*  if (minutes == 0)
        {
            if (seconds == 0)
            {
                if (milliseconds == 0)
                {
                    win1.enabled = true;
                }

            }
        }*/

       /* void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Ast")
            {
                win1.enabled = false;

                Debug.Log("count over"); //enemy랑 air 붙이치면

                //    Destroy(other.gameObject); //Enemy 자기도 죽고

            }

        }
        */

       

        if (minutes <= 0)
        { 
            if (seconds <= 0)
            {
                if (milliseconds <= 0)
                {
                    win1.enabled = true;

                    minutes = 100; ///////////
                    seconds = 100;
                    milliseconds = 100;

            
                }
            }
        }
    }

    public void Restart6()
    {
        minutes = 3;
        seconds = 0;
        milliseconds = 0;
 
        win1.enabled = false;

        //    SceneManager.LoadScene("CJ");

        Debug.Log("time out");

    }
}