using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUpHandler : MonoBehaviour // Lucas
{
    #region Default values
    private spawnManager spawner;
    private Player prefs;

    private float pointMultiply, spawnTime;
    #endregion

    public Text powerUpText;

    public powerUpScriptable[] sTypes;
    powerUpScriptable current;
    powerUpScriptable.Type pusType;
    private void Start()
    {
        spawner = FindObjectOfType<spawnManager>();
        prefs = FindObjectOfType<Player>();

        pointMultiply = spawner.pointMultiplier; spawnTime = spawner.spawnTime;     //Sparar alla variabler i egna variabler innan dem ändras för att hålla koll på vad dem var från början
        pusType = powerUpScriptable.Type.empty; //sätter start läget för powerups till "empty" dvs ingen powerup
    }
    public void randomPu()  //metod för att välja en slumpmässig powerup från en array med alla powerups
    {
        pusType = powerUpScriptable.Type.empty;
        current = sTypes[Random.Range(0, sTypes.Length)];      //väljer en power up att starta slumpmässigt från en array med alla tillgängliga powerups
        StartCoroutine(startPowerUp(current.duration, current.type));   //startar funktionen för att starta en powerup
    }
    private void Update()
    {
        switch (pusType)    //Hanterar vilken powerup som är igång och vad som händer när respektive powerup sätts igång, där empty är standard läget där ingen powerup är igång
        {
            default:
            case powerUpScriptable.Type.empty:
                spawner.pointMultiplier = pointMultiply;
                spawner.o_spawnTime = spawnTime;
                powerUpText.text = null;
                break;
            case powerUpScriptable.Type.doublePoints:
                spawner.pointMultiplier = 5;
                powerUpText.text = "5x points!";
                break;
            case powerUpScriptable.Type.moreLife:
                prefs.lives++;
                powerUpText.text = "An extra life!";
                break;
            case powerUpScriptable.Type.slowerSpawnTime:
                spawner.o_spawnTime = 4;
                powerUpText.text = "Slower spawnrate, doubled points!";
                spawner.pointMultiplier = 2;
                break;
        }
    }
    public IEnumerator startPowerUp(float t, powerUpScriptable.Type type)   //Funktion för att byta till från ingen powerup till den slumpmässigt utvalda powerupen under en viss tid och sedan byta tillbaka.
    {
        pusType = type;
        yield return new WaitForSeconds(t);
        pusType = powerUpScriptable.Type.empty;
    } 
}