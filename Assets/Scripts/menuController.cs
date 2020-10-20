using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public string playableSceneName;
    public void play()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void exit()
    {
        Application.Quit();
        //För att stänga spelet i editor:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}