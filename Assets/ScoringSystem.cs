using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + theScore;

        if(theScore >= 100)
        {
            SceneManager.LoadScene("game over");
        }
    }

    
}
