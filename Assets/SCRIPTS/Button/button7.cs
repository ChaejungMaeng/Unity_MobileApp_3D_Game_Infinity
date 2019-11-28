using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button7 : MonoBehaviour
{
    public GameObject button;
    public GameObject button2;
    public static int buy_2;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void purchase()
    {
        if (GameManager.instance.coins >= 19000)
        {
            button.SetActive(true);
            button2.SetActive(false);
            GameManager.instance.coins -= 19000;
            GameManager.instance.buy7 += 1;
        }
    }

    void Update()
    {
        buy_2 = GameManager.instance.buy7;

        if (buy_2 == 0)
        {
            button.SetActive(false);
        }

        else
        {
            button.SetActive(true);
            button2.SetActive(false);
        }
    }
}
