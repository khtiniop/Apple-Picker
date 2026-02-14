using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        //SceneManager.LoadScene("_Scene_0");
        // OR SceneManager.LoadScene(1);
        SceneManager.LoadScene(1);
    }
}