﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Get()
    {
        return instance;
    }

    public virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
            
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
