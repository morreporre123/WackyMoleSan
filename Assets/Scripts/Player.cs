using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text livesText;
    public Text scoreText;
    public Sprite mouseCursor;
    static public float scorePoints;
    static public int lives = 3;


    private void Start()
    {
<<<<<<< Updated upstream
        //Cursor.
=======
<<<<<<< HEAD
<<<<<<< HEAD
        //Cursor.SetCursor(mouseCursor.texture,cursorMode: CursorMode.Auto);
=======
        //Cursor.
>>>>>>> ff318f8d243594049886ae2636cbf0168ae44981
=======
        //Cursor.
>>>>>>> ff318f8d243594049886ae2636cbf0168ae44981
>>>>>>> Stashed changes
    }

    private void Update()
    {
        print(lives);
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + scorePoints;
    }
}
