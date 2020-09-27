using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [SerializeField] private float lowSpeed = 1.0f;
    [SerializeField] private float highSpeed = 5.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Random.Range(lowSpeed,highSpeed) * Time.deltaTime;
    }
}
