using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    //Anton

    public float spawnrate, subtract, timer;

    public GameObject mole;
    public GameObject[] spawnPoints;

    private bool allowSpawning = true;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnrate && allowSpawning)        //If the timer has the same value as the spawnrate and spawning is allowed...
        {
            SpawnMoles();       //Spawn stuff
        }

        if(spawnrate <= 1)
        {
            subtract = 0;
            spawnrate = 1;
        }

        /*if (Player.lives >= 1)
        {
            Player.lives--;
        }
        else if (Player.lives <= 0)
        {
            //Game over
        }*/
    }
    void SpawnMoles()
    {
        int i = Random.Range(0, spawnPoints.Length);        //Assigns a random number to the mole that spawns
        GameObject currentMole = Instantiate(mole, spawnPoints[i].transform.position, Quaternion.identity);                //Instantiates a random mole on a random spawnpoint
        spawnrate -= subtract;      //Subtracts a value from the spawnrate so moles spawn faster
        timer = 0;      //Reset the timer for next spawn
        Destroy(currentMole, spawnrate);        //Destroys the mole at the same time it takes for a new one to spawn
    }
}