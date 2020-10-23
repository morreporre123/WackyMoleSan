using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour     //Anton
{
    public Text livesText, scoreText, highsScoreText;
    public Sprite mouseCursor;

    private menuController menu;
    
    public float scorePoints;
    
    public int lives = 3;

    float highScore = 0;
    string scorePath = "highScorePath";

    public bool isPaused = false;
    private void Start()
    {
        Time.timeScale = 1;
        menu = FindObjectOfType<menuController>();

        Cursor.SetCursor(mouseCursor.texture, Vector2.zero, CursorMode.Auto);   //Lucas
        highScore = PlayerPrefs.GetFloat(scorePath, 0f); //Lucas
    }
    private void Update()
    {
        if(lives <= 0)
        {
            OnSave();
            menu.pause(true);
        }
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + scorePoints.ToString("0");
        highsScoreText.text = "highScore: " + highScore.ToString("0");

        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            menu.pause(false);
            isPaused = true;
        }
    }
    public void OnSave()    //Lucas
    {
        if (scorePoints > highScore)
        {
            PlayerPrefs.SetFloat(scorePath, scorePoints);
            PlayerPrefs.Save();
        }
    }
}