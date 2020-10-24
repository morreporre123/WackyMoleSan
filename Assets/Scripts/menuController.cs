using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuController : MonoBehaviour //Lucas
{
    public Canvas popup;
    public Button m_continue;
    public Player prefs;

    public void play()  //Funktion för att ladda in scenen där spelet är, Lucas
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void exit()  //funktion för att stänga ner spelet/appen, Lucas
    {
        Application.Quit();     //för att stänga spelet, Lucas
    }
    public void pause(bool hasLost)  //funktion för att pausa spelet med en bool för att kunna skilja mellan frivillig pause och tvångspaus pga förlust, Lucas
    {
        if (hasLost)
        {
            m_continue.interactable = false;    //sätter knappen "continu" till att man inte kan klicka på den om funktionen pausar för att man har förlorat, Lucas
        }
        else
        {
            m_continue.interactable = true;     //sätter knappen "continu" till att man kan klicka på den om funktionen pausar för att man har pausat frivilligt, Lucas
        }
        Time.timeScale = 0;     //fryser tiden dvs pausar spelet, Lucas
        popup.gameObject.SetActive(true);
    }
    public void continu() //Funktion för att fortsätta spelet från pausmenyn, Lucas
    {
        Time.timeScale = 1;     //ofryser spelet/startar spelet igen, Lucas
        popup.gameObject.SetActive(false);  //Gömmer pausmenyn, Lucas
        prefs.isPaused = false;     //sätter paus variabeln till sant
    }
    public void toMainMenu()        //funktion för att gå till huvudmenyn
    {
        print("main menu button");
        SceneManager.LoadScene(0, LoadSceneMode.Single);       //byter scen till huvudmenyscenen
    }
}