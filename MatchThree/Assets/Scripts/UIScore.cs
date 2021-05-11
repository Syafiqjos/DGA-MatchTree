﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{

    public Text highScore;
    public Text currentScore;

    private void Update()
    {
        highScore.text = ScoreManager.Instance.HighScore.ToString();
        currentScore.text = ScoreManager.Instance.CurrentScore.ToString();
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
