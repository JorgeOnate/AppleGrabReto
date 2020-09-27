using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log("destroyed spaceship");
        Destroy(gameObject);
        Score.score++;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "SpaceShip")
        {
            
            Health.health--;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Limit")
        {
            Destroy(gameObject);
        }
        
    }
}
