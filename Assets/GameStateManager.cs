using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameStateManager : MonoBehaviour
{

    int lives;
    static int score = 0;

    public GameObject panel;
    public TextMesh livesText;
    public TextMesh scoreText;

    // Start is called before the first frame update
    void Start()
    {

        lives = 3;
        updateLivesText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoseLive()
    {
        lives--;
        updateLivesText();
        if (lives > 0)
        {
        }
        else
        {
            Time.timeScale = 0;
            panel.SetActive( true);
        }
    }

    public void endGame()
    {

        Debug.Log("Game Over Man");
        Application.Quit();
    }

    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void increaseScore() {
        score += 10;
        updateScoreText();
    }

    public void updateLivesText()
    {
        livesText.text = "Lives: " + lives.ToString();
    }

    public void updateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
