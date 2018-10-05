using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;
//using System.Collections.Generic;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene(int level)
    {
        if (level==1)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if(level==2)
        {
            SceneManager.LoadScene("UIScene");
        }
        else if(level==3)
        {
            //EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }

}
