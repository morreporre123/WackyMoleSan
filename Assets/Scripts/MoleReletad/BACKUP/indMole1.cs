/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indMole1 : MonoBehaviour    //Lucas
{
    float despawnTimer = 2;
    public bool canSpawn = true;
    private moleSpawnerv2 spawner;
    private Player player;

    bool canDespawn = false, startTimer = false;
    private void Awake()
    {
        spawner = FindObjectOfType<moleSpawnerv2>();
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
        if (startTimer)
        {
            despawnTimer -= Time.deltaTime;
        }
        if(despawnTimer <= 0)
        {
            canDespawn = true;
        }
    }
    public void spawn(GameObject mole, float subtract)
    {
        Kill newKill = mole.GetComponent<Kill>();
        despawnTimer = Mathf.Clamp(despawnTimer, 0f, 5f);
        GameObject newMole = Instantiate(mole, transform);
        canSpawn = false;
        startTimer = true;
        newKill.pointTimer = despawnTimer;
        if (canDespawn)
        {
            despawnTimer -= spawner.spawnMultiplierIncrease / 2;
            if (newMole != null)
            {
                canSpawn = true;
                Destroy(newMole);
                player.lives--;
            }
        }
    }
}
*/