using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static int score = 0;
    [SerializeField] private Text scoreText;
    public static void AddScore(int points)
    {
        score = Add(points);
        if (score < 0)
        {
            score = 0;
        }
        PlayerPrefs.SetInt("Score", score);

    }

    private static int Add(int points)
    {
        return score + points;
    }

    private void Update()
    {
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        // Update UI text to display current score
        scoreText.text = "Score: " + score;
    }
}
