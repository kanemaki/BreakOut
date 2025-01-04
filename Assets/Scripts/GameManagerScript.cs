using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMagagerScript : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    public bool gameOver;
    public GameObject gameOverPanel;
    public int numberOfBricks;

    // Start is called before the first frame update
    void Start()
    {
        livesText.text = "LIVES: " + lives;
        scoreText.text = "SCORE: " + score;
        numberOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLives(int changeInLives) 
    {
        lives += changeInLives;
        // Check for no lives left and trigger the end of the game
        if (lives <= 0) {
            lives = 0;
            GameOver();
            gameOverPanel.SetActive(true);
        }

        livesText.text = "LIVES: " + lives;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score;
    }

    public void UpdateNumberOfBricks() {
        numberOfBricks--;
        if (numberOfBricks <= 0) { 
            GameOver ();
            gameOverPanel.SetActive(true);
        }
    }

    public void GameOver()
    { 
        gameOver = true;
        
    }

    public void PlayAgain() {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
