using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 융합공학부 디지털이미징 20165968 맹채정
/// </summary>
/// 

public class Hit6 : MonoBehaviour
{
        public static Text end;      public Canvas intro;


    public Text countT;

    public Text countS;

    public Canvas wining;

    public Canvas ending;

   // public Canvas fairy;
      public Camera myCamera; //카메라     Vector3 cameraDist; //공에서 카메라까지 거리

    public static int coin1;
    public static int star1;


    /// <summary>
    /// 프레임수 30으로 고정
    /// </summary>
    /// 
  

    // Start is called before the first frame update
    void Start()
    {
        ending.enabled = false; //처음엔 끄고(비활성화) // 안끄면 처음부터 game over        //종료화면끄기                 wining.enabled = false;
     //   fairy.enabled = false;

        coin1 = 0;
        star1 = 0;
         SetCountText();         SetCountText2();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetMouseButton(0))         {             intro.enabled = false;
         
            // pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z));          }
       // SetCountText();
    }

     void OnTriggerEnter(Collider other)     {
        if (star1 >= 35 && other.tag == "Ast")
        {
         

            ending.enabled = false; //game over 활성화 true  
            wining.enabled = true;
            //        fairy.enabled = false;

            Destroy(other.gameObject);
            Debug.Log("game over"); //enemy랑 air 붙이치면

            //    Destroy(other.gameObject); //Enemy 자기도 죽고

        }
         if (other.tag == "Ast")         {
            soundAst.instance.PlaySound2();
             GameManager.instance.coins += coin1;             ending.enabled = true; //game over 활성화 true  
            wining.enabled = false; 
    //        fairy.enabled = false;
             Destroy(other.gameObject);             Debug.Log("game over"); //enemy랑 air 붙이치면          //    Destroy(other.gameObject); //Enemy 자기도 죽고          } 
         if (other.tag == "gem1")         {
          //  fairy.enabled = true;
            Destroy(other.gameObject); //Enemy 자기도 죽고

            star1 = star1 + 1;
            SetCountText2();
             coin1 = coin1 + 30;
            SetCountText();

             Debug.Log("gem1 : " + star1); //enemy랑 air 붙이치면
 
            //Debug.Log("Destroy"); //enemy랑 air 붙이치면

        }          if (other.tag == "gem2")         {
       //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();
           
             coin1 = coin1 + 70;
            SetCountText();
             Debug.Log("gem2"); //enemy랑 air 붙이치면
          //  Destroy(other.gameObject); //Enemy 자기도 죽고
            //Debug.Log("Destroy"); //enemy랑 air 붙이치면

        }          if (other.tag == "gem3")         {
       //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();
             coin1 = coin1 + 120;
            SetCountText();
             Debug.Log("gem3"); //enemy랑 air 붙이치면
         //   Destroy(other.gameObject); //Enemy 자기도 죽고
         //   Debug.Log("Destroy"); //enemy랑 air 붙이치면

        }          if (other.tag == "gem4")         {
       //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();
             coin1 = coin1 + 180;
            SetCountText();

             Debug.Log("gem4"); //enemy랑 air 붙이치면
        //    Destroy(other.gameObject); //Enemy 자기도 죽고
        //    Debug.Log("Destroy"); //enemy랑 air 붙이치면

        }          if (other.tag == "gem5")         {
       //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();
             coin1 = coin1 + 240;
            SetCountText();

             Debug.Log("gem5"); //enemy랑 air 붙이치면
        //   Destroy(other.gameObject); //Enemy 자기도 죽고
        //   Debug.Log("Destroy"); //enemy랑 air 붙이치면


        }
        if (other.tag == "gem6")
        {
            //      fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();

            coin1 = coin1 + 300;
            SetCountText();


            Debug.Log("gem6"); //enemy랑 air 붙이치면
                               //   Destroy(other.gameObject); //Enemy 자기도 죽고
                               //   Debug.Log("Destroy"); //enemy랑 air 붙이치면


        }
        if (other.tag == "gem7")
        {
       //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();

            coin1 = coin1 + 350;
            SetCountText();


            Debug.Log("gem7"); //enemy랑 air 붙이치면
                               //   Destroy(other.gameObject); //Enemy 자기도 죽고
                               //   Debug.Log("Destroy"); //enemy랑 air 붙이치면


        }
        if (other.tag == "gem8")
        {
      //      fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText2();

            coin1 = coin1 + 400;
            SetCountText();


            Debug.Log("gem8"); //enemy랑 air 붙이치면
                               //   Destroy(other.gameObject); //Enemy 자기도 죽고
                               //   Debug.Log("Destroy"); //enemy랑 air 붙이치면


        }     }


    void SetCountText2()
    {
        countS.text =  star1.ToString() + " / 35";

        if (star1 >= 35)
        {
            GameManager.instance.coins += coin1;
            wining.enabled = true;
            ending.enabled = false;
        }
    }

    void SetCountText()
    {
        countT.text =  coin1.ToString();
      
    }


     public void Restart3()     {
        countT.text = "0";
        countS.text = "0 / 35";
         coin1 = 0;
        star1 = 0;
         wining.enabled = false;
         ending.enabled = false; //endgame을 비활성화 한다        //박스 초기화                  //    SceneManager.LoadScene("CJ");          Debug.Log("bring back");           }
 
}
