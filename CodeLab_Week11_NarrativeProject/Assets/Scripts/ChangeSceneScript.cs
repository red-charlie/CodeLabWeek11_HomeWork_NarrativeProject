using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneScript : MonoBehaviour
{ // almost exactly the script that was completed in class, but also I just ripped this from my walking sim
public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName); //change to whatever scene is named by sceneName
    }
}
