using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundAst : MonoBehaviour
{
    public AudioClip soundExplosion2; //재생할 소리를 변수로 담습니다.
    AudioSource myAudio2; //AudioSorce 컴포넌트를 변수로 담습니다.
    public static soundAst instance;  //자기자신을 변수로 담습니다.


    void Awake() //Start보다도 먼저, 객체가 생성될때 호출됩니다
    {
        if (soundAst.instance == null) //incetance가 비어있는지 검사합니다.
        {
            soundAst.instance = this; //자기자신을 담습니다.
        }
    }

    void Start()
    {
        myAudio2 = this.gameObject.GetComponent<AudioSource>(); //AudioSource 오브젝트를 변수로 담습니다.
    }

    public void PlaySound2()
    {
        myAudio2.PlayOneShot(soundExplosion2); //soundExplosion을 재생합니다.
    }

    void Update()
    {

    }
}
