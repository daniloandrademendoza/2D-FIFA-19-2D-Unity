using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//using System.Collections.Generic;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene(int level)
    {
        SceneManager.LoadScene("SampleScene");
       
    }

}
