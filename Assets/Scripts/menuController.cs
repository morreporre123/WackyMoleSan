using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour //Lucas
{
    public Canvas popup;
    public Button m_continue;
    public Player prefs;

    public void play()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);        //För att ladda in rätt scen
    }
    public void exit()
    {
        Application.Quit();     //för att stänga spelet
        UnityEditor.EditorApplication.isPlaying = false; // för att stänga spelet i editor
    }
    public void pause(bool hasLost)
    {
        if (hasLost)
        {
            m_continue.interactable = false;
        }
        else
        {
            m_continue.interactable = true;
        }
        Time.timeScale = 0;
        popup.gameObject.SetActive(true);
    }
    public void continu()
    {
        Time.timeScale = 1;
        popup.gameObject.SetActive(false);
        prefs.isPaused = false;
    }
    public void toMainMenu()
    {
        print("main menu button");
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}