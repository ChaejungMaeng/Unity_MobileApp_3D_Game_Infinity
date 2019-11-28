using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteriod : MonoBehaviour
{
   // public Canvas ending2;

    // Start is called before the first frame update
    void Start()
    {
 //       ending2.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "plane")
        {
            ending2.enabled = true; //game over 활성화 true  

            Debug.Log("end2"); //enemy랑 air 붙이치면

            Destroy(gameObject);
            Debug.Log("game over"); //enemy랑 air 붙이치면
             //enemy 죽고
            //Destroy(other.gameObject); //Air 자기도 죽고

        }
    }

    public void Restart5()
    {

        ending2.enabled = false; //endgame을 비활성화 한다        //박스 초기화 

        //    SceneManager.LoadScene("CJ");

        Debug.Log("ending");


    }*/
}
