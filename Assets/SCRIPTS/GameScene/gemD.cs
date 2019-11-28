using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemD : MonoBehaviour
{
/// <summary>
/// 융합공학부 디지털이미징 20165968 맹채정
/// </summary>
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)     {          if (other.tag == "plane") //보석과 비행기 부딪히면          {
            soundManager.instance.PlaySound(); //보석 획득 소리 재생
             Debug.Log("GEM");              Destroy(gameObject); //보석 없애기


        }      }

  
}
