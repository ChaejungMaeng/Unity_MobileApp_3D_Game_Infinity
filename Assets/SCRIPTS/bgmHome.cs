using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmHome : MonoBehaviour
{
    public AudioSource homeBgm;
    // Start is called before the first frame update
    void Start()
    {
        homeBgm.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        while(Time.time%2f!=0f)
        {
            homeBgm.volume += 0.2f;
        }
    }
}
