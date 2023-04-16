using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    private float minY = -10f;
    private int ScorePen = 1;

    private void Update()
    {
        
        if (transform.position.y < minY)
        {
            Destroy(gameObject);
            ScoreManager.AddScore(-ScorePen);
        }
    }
}
