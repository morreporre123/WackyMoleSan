using UnityEngine;
using System.Collections.Generic;
public class moleSpawnerv2 : MonoBehaviour  //Lucas
{
    public indMole[] moles;

    private List<indMole> ableToSpawn = new List<indMole>();

    public GameObject molePrefab, powerUpPrefab;

    public float spawnTimer = 2, spawnMultiplier, spawnMultiplierIncrease;

    public int chanceForPowerUp;
    private void Update()
    {
        spawnMultiplier = Mathf.Clamp(spawnMultiplier, 0, 1.6f);
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            spawnMoles();
            spawnTimer = 2 - spawnMultiplier;
            spawnMultiplier += spawnMultiplierIncrease;
        }
    }
    public void spawnMoles()
    {
        foreach (indMole mole in moles)
        {
            if (mole.canSpawn)
            {
                ableToSpawn.Add(mole);
            }
        }
        int i = Random.Range(0, ableToSpawn.Count);
        int c = Random.Range(0, 100);
        if(c < chanceForPowerUp)
        {
            StartCoroutine(ableToSpawn[i].spawn(powerUpPrefab, spawnMultiplier));
            print("Spawned powerup");
        }
        else
        {
            StartCoroutine(ableToSpawn[i].spawn(molePrefab, spawnMultiplier));
            print("spawned mole");
        }
    }
}