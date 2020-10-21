using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indMole : MonoBehaviour    //Lucas
{
    float timer = 2;
    public bool canSpawn = true;
    private moleSpawnerv2 spawner;
    private void Awake()
    {
        spawner = FindObjectOfType<moleSpawnerv2>();
    }
    public IEnumerator spawn(GameObject mole, float subtract)
    {
        timer = Mathf.Clamp(timer, 0f, 5f);
        GameObject newMole = Instantiate(mole, transform);
        canSpawn = false;
        yield return new WaitForSeconds(timer);
        timer -= spawner.spawnMultiplierIncrease/2;
        if(newMole != null)
        {
            Destroy(newMole);
            // tappa liv ?
        }
        canSpawn = true;
    }
}