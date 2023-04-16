using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    [SerializeField]private Text scoreText;
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = "Your Score: " + score;
        print(score);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
