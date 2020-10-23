using UnityEngine;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour //Lucas
{
    public Canvas popupPause;
    public void play()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);        //För att ladda in rätt scen
    }
    public void exit()
    {
        Application.Quit();     //för att stänga spelet
        UnityEditor.EditorApplication.isPlaying = false; // för att stänga spelet i editor
    }
    public void pause()
    {
        Time.timeScale = 0;
        popupPause.gameObject.SetActive(true);
    }
    public void restart()
    {
        Time.timeScale = 0;
    }
}