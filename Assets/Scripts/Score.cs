using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text stext;
    public Text htext;
    public Button increase;
    public Button save;

    int score = 0;
    int highScore = 0;
    string scorePath = "highScorePath";
    void Start()
    {
        highScore = PlayerPrefs.GetInt(scorePath, 0);
    }
    void Update()
    {
        stext.text = "Score: " + score.ToString();
        htext.text = "High Score: " + highScore.ToString();
    }
    public void OnSave()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetInt(scorePath, score);
        }
    }
    public void increaseScore()
    {
        score++;
    }
}