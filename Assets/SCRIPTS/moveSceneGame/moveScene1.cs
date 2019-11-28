using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene1 : MonoBehaviour
{
   
    public void GoToGame()
    {
        SceneManager.LoadScene("Flight1");
    }
}
