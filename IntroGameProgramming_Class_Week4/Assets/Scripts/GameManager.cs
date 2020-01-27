﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;

    public void Awake()
    { 
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("error: too many GMs. begining purge.");
        }
    }
}

