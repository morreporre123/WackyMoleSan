using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text livesText;
    public Text scoreText;
    public Sprite mouseCursor;
    static public int scorePoints;
    static public int lives = 3;


    private void Start()
    {
        
    }

    private void Update()
    {
        print(lives);
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + scorePoints;
    }
}
