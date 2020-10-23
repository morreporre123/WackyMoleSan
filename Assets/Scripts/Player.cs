using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour     //Anton
{
    public Text livesText, scoreText, highsScoreText;
    public Sprite mouseCursor;
    
    public float scorePoints;
    
    public int lives = 3;

    float highScore = 0;
    string scorePath = "highScorePath";
    private void Start()
    {
        Cursor.SetCursor(mouseCursor.texture, Vector2.zero, CursorMode.Auto);   //Lucas
        highScore = PlayerPrefs.GetFloat(scorePath, 0f); //Lucas
    }
    private void Update()
    {
        if(lives <= 0)
        {
            OnSave();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + scorePoints.ToString("0");
        highsScoreText.text = "highScore: " + highScore.ToString("0");
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