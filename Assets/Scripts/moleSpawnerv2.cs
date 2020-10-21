using UnityEngine;
using System.Collections.Generic;
public class moleSpawnerv2 : MonoBehaviour
{
    public indMole[] moles;
    public float spawnTimer = 2;
    public GameObject mole;
    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if(spawnTimer <= 0)
        {
            int i = getRandomSpawn();
            if (moles[i].canSpawn)
            {
                StartCoroutine(moles[i].spawn(mole));
                spawnTimer = 2;
            }
        }
    }
    int getRandomSpawn()
    {
        int i = Random.Range(0, moles.Length);
        return i;
    }
}