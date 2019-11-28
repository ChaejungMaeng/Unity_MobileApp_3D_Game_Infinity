using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public static int coinF;
       // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinF = GameManager.instance.coins;
        Text uiText = GetComponent<Text>();
        uiText.text = coinF.ToString();
    }
}
