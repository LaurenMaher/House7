﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    //in the class:

    void OnMouseUp()
    {
        SceneManager.LoadScene("Level1");
    }
}