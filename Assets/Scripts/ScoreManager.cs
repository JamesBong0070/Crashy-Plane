using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    int score = 0;
    int highscore = 0;
    public GameObject crashUI;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highscore = PlayerPrefs.GetInt("Highscore", 0); // Load the highscore from PlayerPrefs
        scoreText.text = "Score = " + score;
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    void Update()
    {
        //ShowCrashUI(); // Call the ShowCrashUI method every frame
    }

    public void AddScore()
    {
        score++; // Increment the score by 1
        scoreText.text = "Score = " + score;

        if (score > highscore) // Check if the current score is greater than the highscore
        {
            highscore = score;
            highscoreText.text = "HIGHSCORE: " + highscore.ToString();

            PlayerPrefs.SetInt("Highscore", highscore); // Save the new highscore to PlayerPrefs
            PlayerPrefs.Save(); // Ensure the highscore is saved immediately
            Debug.Log("New Highscore: " + highscore); // Log the new highscore
        }
    }

    public void ShowCrashUI()
    {
        // Show the crash UI
        if (playerCrash.instance.hasCrashed)
        {
            crashUI.SetActive(true);
        }
        else
        {
            crashUI.SetActive(false);
        }
    }
}

