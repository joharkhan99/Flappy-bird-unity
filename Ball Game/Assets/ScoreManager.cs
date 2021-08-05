using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("Score", 0);     //store score during game
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score++;
    }

    public void StopScore()
    {
        PlayerPrefs.SetInt("Score", score);     //this is score during game

        // if previous high score exists
        if (PlayerPrefs.HasKey("HighScore"))
        {
            // update score if he scores more
            if(score > PlayerPrefs.GetInt("HighScore"))
            {
                PlayerPrefs.SetInt("HighScore", score);
            }
        }
        // else currnt score as high score
        else
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

}
