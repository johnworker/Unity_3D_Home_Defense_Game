using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int playerHealth = 3;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
    public GameObject gameOverPanel;

    void Start()
    {
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        UpdateScore(0);
        UpdateHealth(playerHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScore(score);
    }

    void UpdateScore(int currentScore)
    {
        scoreText.text = "Score: " + currentScore;
    }

    public void UpdateHealth(int currentHealth)
    {
        healthText.text = "Health: " + currentHealth;
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
