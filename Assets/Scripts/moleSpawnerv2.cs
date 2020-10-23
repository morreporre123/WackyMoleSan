using UnityEngine;
using System.Collections.Generic;
public class moleSpawnerv2 : MonoBehaviour  //Lucas
{
    public indMole[] moles;

    private List<indMole> ableToSpawn = new List<indMole>();

    private Player prefs;

    public GameObject molePrefab, powerUpPrefab;

    public float spawnTimer, originSpawnTimer, spawnMultiplier;

    public int chanceForPowerUp;
    private void Awake()
    {
        prefs = FindObjectOfType<Player>();
        originSpawnTimer = spawnTimer;
    }
    private void Update()
    {
        float l = 0;

        spawnTimer = Mathf.Clamp(spawnTimer, 0, 1.6f);
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            l++;
            spawnMoles();
            spawnTimer = originSpawnTimer - l * spawnMultiplier;
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
    public void despawn(GameObject despawnObject, bool isClicked, float points)
    {
        print("despawned");
        Destroy(despawnObject);
        if (isClicked)
        {
            prefs.scorePoints += points;
            //camerashake
        }
        else
        {
            prefs.lives--;
        }
    }
}