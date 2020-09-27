using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAstronaut : MonoBehaviour
{

    public GameObject Spaceship;
    public GameObject LowerLimit;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SpaceShip")
        {
            
            Score.score--;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Limit")
        {
            Health.health--;
            Destroy(gameObject);
        }
        
    }
}
