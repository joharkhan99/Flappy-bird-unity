using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    bool gameOver;

        void Awake()
        {
            // this will keep the GameManager script forever throughtout the game
            DontDestroyOnLoad(this.gameObject);

            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
        gameOver = true;
        }

        // Update is called once per frame
        void Update()
    {
        
    }

    public void gameStart() {
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().startSpawningPipes();
    }

    public void GameOver() {
        gameOver = false;
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().stopSpawningPipes();
        ScoreManager.instance.StopScore();
        UIManager.instance.GameOver();
    }


}
