using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    [SerializeField]public float maxTime = 0;
    private float _timer = 0;
    public GameObject Alien;
    public GameObject LowerLimit;
    
    [SerializeField]public float LeftLimit = 7.3f;
    [SerializeField]public float RightLimit = 7.3f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newAlien = Instantiate(Alien);
        newAlien.transform.position = transform.position + new Vector3(Random.Range(-LeftLimit,RightLimit), y:0,0);

    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            GameObject newAlien = Instantiate(Alien);
            newAlien.transform.position = transform.position + new Vector3(Random.Range(-LeftLimit,RightLimit), y:0,0);
            
            Destroy(newAlien,15);
            _timer = 0;

        }

        
        _timer += Time.deltaTime;
    }
}
