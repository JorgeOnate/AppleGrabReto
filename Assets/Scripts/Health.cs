﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] public static int health = 3;
    void Start()
    {
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = health.ToString();
        if (Health.health.Equals(0))
        {
            SceneManager.LoadScene(3);
        }
        
    }
}
