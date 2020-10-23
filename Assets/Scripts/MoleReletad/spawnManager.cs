using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public Transform[] moles;

    public GameObject prefabMole, prefabPowerUp;

    public float spawnTime, maxPointsFromMole, spawnTimeSubtract, spawnTimeUntilZero;
    float o_spawnTime;

    float despawnTime = 2;
    void Start()
    {
        o_spawnTime = spawnTime;
    }
    void Update()
    {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0)
        {
            spawn();
            spawnTime = o_spawnTime;
        }
    }
    public void spawn()
    {
        int i = Random.Range(0, moles.Length);
        spawnTime =- 0.25f;

        int randomEvent = Random.Range(0, 8);
        if (moles[i].childCount == 0)
        {
            GameObject newMole = Instantiate(prefabMole, moles[i], false);
            clickable newOnMole = newMole.GetComponent<clickable>();
            newOnMole.live(despawnTime, maxPointsFromMole);

        }
        else
        {
            spawn();
        }
    }
}