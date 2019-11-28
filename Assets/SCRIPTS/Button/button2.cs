using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button2 : MonoBehaviour
{
    public GameObject button;
    public GameObject buttonSec;
    public static int buy_2;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void purchase()
    {
        if (GameManager.instance.coins >= 1500)
        {
            button.SetActive(true);
            buttonSec.SetActive(false);
            GameManager.instance.coins -= 1500;
            GameManager.instance.buy2 += 1;
        }
    }

    void Update()
    {
        buy_2 = GameManager.instance.buy2;

        if (buy_2 == 0)
        {
            button.SetActive(false);
        }

        else
        {
            button.SetActive(true);
            buttonSec.SetActive(false);
        }
    }
}
