﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputManager:MonoBehaviour
{
    public static InputManager IM;

    public KeyCode jump;
    public KeyCode spawnFlare;
    public KeyCode dash;

void Awake()
{
    //Singleton pattern
    if (IM == null)
    {
        DontDestroyOnLoad(gameObject);
        IM = this;
    }
    else if (IM != this)
    {
        Destroy(gameObject);
    }
}

}