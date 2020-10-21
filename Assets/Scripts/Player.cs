using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour     //Anton
{
    public Text livesText;
    public Text scoreText;
    public Sprite mouseCursor;
    static public float scorePoints;
    static public int lives = 3;


    private void Start()
    {
        Cursor.SetCursor(mouseCursor.texture, Vector2.zero, CursorMode.Auto);   //Lucas
    }

    private void Update()
    {
        //print(lives);
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + scorePoints;
    }
}
