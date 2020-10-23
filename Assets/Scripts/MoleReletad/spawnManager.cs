using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour   //Lucas
{
    public Transform[] moles;

    public GameObject prefabMole, prefabPowerUp;

    public float spawnTime, maxPointsFromMole, spawnTimeSubtract, spawnTimeUntilZero;
    public float o_spawnTime;

    float despawnTime = 2;

    public float pointMultiplier = 1;
    void Start()
    {
        o_spawnTime = spawnTime;    //Sätetr start spawntime till spawntime när det startar
    }
    void Update()
    {
        spawnTime -= Time.deltaTime;    //sänker spawntime med 1 varje sekund
        if(spawnTime <= 0)  //när timern når 0 eller under startar funktionen för att skapa en ny mole
        {
            spawn();
            spawnTime = o_spawnTime;    //startar om timern
        }
    }
    public void spawn()
    {
        int i = Random.Range(0, moles.Length);  //väljer ett nummer från 0 till längden på arrayen "moles" slumpmässigt och sparar det i "i"

        int randomEvent = Random.Range(0, 10);  //väljer mellan olika event med olika stora chanser att inträffa
        if (moles[i].childCount == 0)   //checkar om den valda platsen i arrayen inte redan har en mole skapad, om den har det så väljer den en ny plats i arrayen, om inte så...
        {
            if (randomEvent < 9) //Event 1, 90% chans
            {
                print("mole spawn");
                GameObject newMole = Instantiate(prefabMole, moles[i], false);  //skapar en ny version av "prefabMole" på den valda platsen, med den valda platsen som Parent
                clickable newOnMole = newMole.GetComponent<clickable>();       //sätter "newOnMole" till skriptet på den nya versionen
                newOnMole.live(despawnTime, maxPointsFromMole, pointMultiplier);     //startar skriptet på den nya versionen
            }
            else
            {
                print("powerup spawn");
                GameObject newPowerUp = Instantiate(prefabPowerUp, moles[i], false);   //samma kod som i ifsatsen ovan bara det att man inte får några poäng från att klicka på den
                clickable newOnPu = newPowerUp.GetComponent<clickable>();
                newOnPu.live(despawnTime, 0, 0);
            }
        }
        else
        {
            spawn();       //startar om funktionen
        }
    }
}