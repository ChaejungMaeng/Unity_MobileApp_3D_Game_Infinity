using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameStart : MonoBehaviour
{
    public Canvas gamestart;
    // Start is called before the first frame update
    void Start()
    {
        gamestart.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3f)
        {
            gamestart.enabled = false;

        }
    }
}
