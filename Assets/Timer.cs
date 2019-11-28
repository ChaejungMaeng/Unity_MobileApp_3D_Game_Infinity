using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {


    public Text timerText;
    private float startTime;
    public float milliseconds, seconds, minutes, hours;

   // public Canvas time2;
  //  public Text timeSet;

    // Use this for initialization
    void Start () {
      //  time2.enabled = false;

        startTime = Time.time;

    }
    
    // Update is called once per frame
    void Update () {
      //  timeSet.text=((int)Time.time).ToString();

        float t = Time.time - startTime;

        minutes = (int)(Time.timeSinceLevelLoad / 60f);
        seconds = (int)(Time.timeSinceLevelLoad % 60f);
        milliseconds = (int)(Time.timeSinceLevelLoad * 100f) % 100;

        timerText.text = "TIME "+ minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

       /* if(time2.enabled == true){
            
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
        }*/

    }

}

