using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautMovement : MonoBehaviour
{
    [SerializeField] private float lowSpeed = 1.0f;
    [SerializeField] private float highSpeed = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Random.Range(lowSpeed,highSpeed) * Time.deltaTime;
    }
}
