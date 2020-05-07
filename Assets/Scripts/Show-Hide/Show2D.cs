﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show2D : MonoBehaviour
{

    [SerializeField] private Image customImage;
    [SerializeField] private Button customImage2;


    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            customImage.enabled = true;
        }
        {
            if (Input.GetKey(KeyCode.B))
            {
                customImage.enabled = false;
            }
        }
    }
}