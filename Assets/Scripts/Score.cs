using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField]public static int score = 50;
    
    void Start()
    {
        score = 50;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
        
        if (Score.score.Equals(0))
        {
            SceneManager.LoadScene(2);
        }
    }
}
