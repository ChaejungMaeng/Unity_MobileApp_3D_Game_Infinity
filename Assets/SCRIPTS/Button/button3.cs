using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button3 : MonoBehaviour
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
        if (GameManager.instance.coins >= 3000)
        {
            button.SetActive(true);
            button2.SetActive(false);
            GameManager.instance.coins -= 3000;
            GameManager.instance.buy3 += 1;
        }
    }

    void Update()
    {
        buy_2 = GameManager.instance.buy3;

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
