using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner1 : MonoBehaviour
{
    //Anton

    public float spawnrate, subtract, timer;

    public GameObject mole;
    public GameObject[] spawnPoints;

    public bool[] bArr;
    private bool allowSpawning = true;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnrate && allowSpawning)
        {
            SpawnMoles();
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
        int i = Random.Range(0, spawnPoints.Length);
        GameObject currentMole = Instantiate(mole, spawnPoints[i].transform.position, Quaternion.identity);                //Instantiates a random mole on a random spawnpoint
        spawnrate -= subtract;
        timer = 0;
        Destroy(currentMole, spawnrate);
    }
}