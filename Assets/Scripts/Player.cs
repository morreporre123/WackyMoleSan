using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour     //Anton & Lucas
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
        Time.timeScale = 1;     //Ser till så att spelet inte är pausat när det startar, Lucas
        menu = FindObjectOfType<menuController>();

        Cursor.SetCursor(mouseCursor.texture, Vector2.zero, CursorMode.Auto); //Sätter muspekarens bild till en egen bild, Lucas
        highScore = PlayerPrefs.GetFloat(scorePath, 0f);    //Sätter highscore till den sparade variabeln eller 0 om den inte hittar något sparat värde, Lucas
    }
    private void Update()
    {
        if(lives <= 0)  //När liv når 0 så...
        {
            OnSave();
            menu.pause(true);
        }
        livesText.text = "Lives: " + lives; // sätter liv texten till liv variabeln, Lucas
        scoreText.text = "Score: " + scorePoints.ToString("0");     //sätter score texten till score variabeln utan decimaler, Lucas
        highsScoreText.text = "highScore: " + highScore.ToString("0");   //sätter highscore texten till highscore variabeln utan decimaler, Lucas

        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused) // när escape trycks ner och spelet inte är pausat så sätts pause till sant och funktionen för att pausa spelet startar, Lucas
        {
            menu.pause(false);
            isPaused = true;
        }
    }
    public void OnSave()    // Sparar highscore variabeln, Lucas
    {
        if (scorePoints > highScore) //Om score är större än highscore så sparas score som nytt highscore, Lucas
        {
            PlayerPrefs.SetFloat(scorePath, scorePoints);
            PlayerPrefs.Save();
        }
    }
}