﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void restartGame()
    {
        GameConfigs.instance.restartConfigs();
        SceneManager.LoadScene("mainScreen");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
