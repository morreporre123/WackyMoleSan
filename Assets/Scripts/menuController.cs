using UnityEngine;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour //Lucas
{
    public Canvas popup;
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
        popup.gameObject.SetActive(true);
    }
    public void continu()
    {
        Time.timeScale = 1;
        popup.gameObject.SetActive(false);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void toMainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}