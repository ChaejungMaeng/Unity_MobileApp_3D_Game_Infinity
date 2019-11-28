using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// 융합공학부 디지털이미징 20165968 맹채정
/// </summary>
/// 
/// 
public class Hit1 : MonoBehaviour
{
        public static Text end;      public Canvas intro;


    public Text countT; //모은 총 코인 수 Canvas

    public Text countS; //모은 총 보석 수 Canvas

    public Canvas wining; //이겼을때 Canvas

    public Canvas ending; //게임끝났을때 Canvas

   // public Canvas fairy;
      public Camera myCamera; //카메라     Vector3 cameraDist;  //카메라 거리

    public static int coin1; //코인 변수
    public static int star1; //별 변수

    /// <summary>
    /// 프레임수 30으로 고정
    /// </summary>
    /// 
  


    // Start is called before the first frame update
    void Start()
    {
        ending.enabled = false; //처음엔 끄고(비활성화) //종료화면끄기               wining.enabled = false;    //승리화면끄기

        //변수 초기화 
        coin1 = 0;
        star1 = 0;

        // 별과 코인 수 출력 함수          SetCountText();         SetCountText1();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))         {             intro.enabled = false; //마우스 입력있으면 게임 스타트 처음화면 false
                  }
       // SetCountText();
    }

     void OnTriggerEnter(Collider other)  //충돌체크
    {         if (other.tag == "Ast") //운석 충돌시
        {
            soundAst.instance.PlaySound2(); //충돌 BGM 재생

            GameManager.instance.coins += coin1;             ending.enabled = true; //game over 활성화 true  
            wining.enabled = false;
            //        fairy.enabled = false;

            Destroy(other.gameObject);             Debug.Log("game over"); //

        } 
         if (other.tag == "gem1") //gem1 보석 충돌시 
        {
            //  fairy.enabled = true;
            Destroy(other.gameObject); //보석 사라짐

            star1 = star1 + 1; //보석 (별) 개수 하나 증가

            SetCountText1(); //보석 카운트 1증가 출력
             coin1 = coin1 + 30; // 코인 30 증가
            SetCountText(); //코인 카운트 30 증가 출력


            Debug.Log("gem1 : " + star1); //별과 부딪히면


        }          if (other.tag == "gem2") //gem2 보석 충돌시 
        {
            //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText1();


            coin1 = coin1 + 70;
            SetCountText();
             Debug.Log("gem2");
        }          if (other.tag == "gem3")         {
            //     fairy.enabled = true;

            star1 = star1 + 1;
            SetCountText1();
             coin1 = coin1 + 120;
            SetCountText();
             Debug.Log("gem3");
        }

            if (other.tag == "gem4")
            {
                //     fairy.enabled = true;

                star1 = star1 + 1;
                SetCountText1();

                coin1 = coin1 + 180;
                SetCountText();


                Debug.Log("gem4");
            }

            if (other.tag == "gem5")
            {
                //     fairy.enabled = true;

                star1 = star1 + 1;
                SetCountText1();

                coin1 = coin1 + 240;
                SetCountText();


                Debug.Log("gem5");

            }
            if (other.tag == "gem6")
            {
                //      fairy.enabled = true;

                star1 = star1 + 1;
                SetCountText1();

                coin1 = coin1 + 300;
                SetCountText();


                Debug.Log("gem6");

            }
            if (other.tag == "gem7")
            {
                //     fairy.enabled = true;

                star1 = star1 + 1;
                SetCountText1();

                coin1 = coin1 + 350;
                SetCountText();


                Debug.Log("gem7");

            }
            if (other.tag == "gem8")
            {
                //      fairy.enabled = true;

                star1 = star1 + 1;
                SetCountText1();

                coin1 = coin1 + 400;
                SetCountText();


                Debug.Log("gem8");
            }             if (star1 >= 10 && other.tag == "Ast") //별 개수 다 채웠으면서 운석과 부딪히면(게임 오버뜨는거 방지)
            {
                ending.enabled = false; //game over 활성화 false
                wining.enabled = true;
                //        fairy.enabled = false;

                Destroy(other.gameObject);
                Debug.Log("game over"); //enemy랑 air 붙이치면

            }
        }


        void SetCountText1() //별 개수 화면에 출력
        {
            countS.text = star1.ToString() + " / 10";

            if (star1 >= 10) //별개수 다 채우면 승리 화면 true
            {
                GameManager.instance.coins += coin1;  //전체 코인 수 instance로 저장 (플레이어가 가지고 있는)
                wining.enabled = true; //승리화면 true
                ending.enabled = false; //게임오버 false
            }
        }

        void SetCountText() //모은 코인수 출력
        {
            countT.text = coin1.ToString();

        }


         public void Restart3() //restart 버튼 눌렀을때 게임 다시시작
        {
            countT.text = "0";  //코인개수 0으로 
            countS.text = "0 / 10"; //별 개수 0으로

            coin1 = 0; //코인수 0으로 
            star1 = 0; //별 수 0으로

            wining.enabled = false; //승리화면 비활성화

            ending.enabled = false; //게임오버화 비활성화 한다                   Debug.Log("bring back");

        }

}
