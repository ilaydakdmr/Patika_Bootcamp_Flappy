using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    void Start()
    {
        Score = 0;
        scoreText.text = Score.ToString();
    }

    
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        Score++;
        scoreText.text = Score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
