using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) 
    { 
        PlayerScore = PlayerScore + scoreToAdd;
        scoreText.text = PlayerScore.ToString();
        scoreSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver ()
    {
        gameOverScreen.SetActive(true);
    }
}
