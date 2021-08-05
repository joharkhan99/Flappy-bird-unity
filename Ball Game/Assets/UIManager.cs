using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text scoreText;
    public GameObject GameOverPanel;

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
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void Replay() {
        // SceneManager.LoadScene(""+SceneManager.GetActiveScene()+"");      //reload the same scene/level1
        // both above and below are same
        SceneManager.LoadScene("Level1");      //reload the same scene/level1
    }

    public void Menu() { 
        SceneManager.LoadScene("Menu");      //reload the menu scene
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
    }

}
