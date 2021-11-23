using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public float score;
    [SerializeField] private Text scoreText;
    public void LoadLevel(int gameScene)
    {
        SceneManager.LoadScene(gameScene);
    }

    public void UpdateScores()
    {
        scoreText.text = score + " points";
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
