using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectSnap : MonoBehaviour
{
    public RectTransform panel;//To hold the ScrollPanel
    public Button[] bttn;
    public RectTransform center;//center to compare te distance for each button

    private float[] distance;//all buttons' distance to the center
    private bool dragging = false; //will be true, while we drag the panel
    private int bttnDistance; //will hold the distance between the buttons
    private int minButtonNum;//hold the number of the buttons, with smallest distance to center

    void Start()
    {
        int bttnLenth = bttn.Length;
        distance = new float[bttnLenth];

        //get distance between buttons
        bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);
      
    }

    void Update()
    {
        for(int i = 0; i < bttn.Length; i++)
        {
            distance[i] = Mathf.Abs(center.transform.position.x - bttn[i].transform.position.x);
        }

        float minDistance = Mathf.Min(distance);//get the min distance

        for(int a = 0; a < bttn.Length; a++)
        {
            if (minDistance == distance[a])
            {
                minButtonNum = a;
            }
        }

        if (!dragging)
        {
            LerpToBttn(minButtonNum * (-bttnDistance));
        }
    }

    void LerpToBttn(int position)
    {
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.deltaTime * 10f);
        Vector2 newPosition = new Vector2(newX, panel.anchoredPosition.y);

        panel.anchoredPosition = newPosition;
    }

    public void StartDrag()
    {
        dragging = true;
    }

    public void EndDrag()
    {
        dragging = false;
    }
}
