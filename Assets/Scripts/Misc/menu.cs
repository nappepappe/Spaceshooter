﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Main"); //Laddar scenen Main

    }
    public void StartGame()
    {
        SceneManager.LoadScene("Main"); //Laddar scenen Main
    }
    public void Exit() 
    {
        Application.Quit(); //stänger av spelet
    }

}
