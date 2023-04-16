using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    [SerializeField]private float totalTime = 60.0f; // Tổng thời gian cho màn chơi
    private float timeLeft; // Thời gian còn lại
    [SerializeField]private Text textTime;
    

    void Start()
    {
        timeLeft = totalTime; // Khởi tạo thời gian còn lại bằng tổng thời gian
        UpdateTimeText();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime; // Giảm thời gian còn lại
        
        if (timeLeft <= 0)
        {
            
            // Thời gian hết, kết thúc màn chơi
            EndGame();
        }
        UpdateTimeText();
    }

    private void EndGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void UpdateTimeText()
    {
        // Cập nhật giá trị của Text Object
        textTime.text = "Time: " + Mathf.RoundToInt(timeLeft).ToString();
    }
}
