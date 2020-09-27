using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class AstronautSpawner : MonoBehaviour
{
    [SerializeField]public float maxTime = 0;
    private float _timer = 0;
    public GameObject Astronaut;
    public GameObject LowerLimit;
    
    [SerializeField]public float LeftLimit = 0;
    [SerializeField]public float RightLimit = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newAstro = Instantiate(Astronaut);
        newAstro.transform.position = transform.position + new Vector3(Random.Range(-LeftLimit,RightLimit), y:0,0);

    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            GameObject newAstro = Instantiate(Astronaut);
            newAstro.transform.position = transform.position + new Vector3(Random.Range(-LeftLimit,RightLimit), y:0,0);
            
            Destroy(newAstro,15);
            _timer = 0;

        }

        
        _timer += Time.deltaTime;
    }

    
}
