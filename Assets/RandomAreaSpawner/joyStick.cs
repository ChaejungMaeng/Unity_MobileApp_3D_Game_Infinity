using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joyStick : MonoBehaviour
{
    protected Joystick joystick;

    //protected
    // Use this for initialization

    void Start()
    {

        joystick = FindObjectOfType<Joystick>();

    }
// Update is called once per frame

    void Update()
    {

  //  Vector3 pos = GetComponent<Transform>().position;

//    GetComponent<Transform>().position = new Vector3(joystick.Horizontal * -2f, -1.5f, 0);
    }

}
