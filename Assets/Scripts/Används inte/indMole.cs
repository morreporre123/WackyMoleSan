using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indMole : MonoBehaviour    //Lucas
{
    private moleSpawnerv2 spawner;
    private Player player;

    public bool canSpawn = true;
    bool startTimer;

    public float despawnTimer = 2.5f;
    private void Awake()
    {
        spawner = FindObjectOfType<moleSpawnerv2>();
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
        despawnTimer = Mathf.Clamp(despawnTimer, 0.5f, 2.5f);
    }
    public IEnumerator spawn(GameObject spawnObj, float subtract)
    {
        canSpawn = false;
        Kill newKill = spawnObj.GetComponent<Kill>();
        
        newKill.spawnedFrom = this;

        GameObject newSpawnObj = Instantiate(spawnObj);
        newSpawnObj.transform.position = transform.position;

        yield return new WaitForSeconds(despawnTimer);
        if (!newKill.hasClicked)
        {
            spawner.despawn(newSpawnObj, false, 0);
        }

        canSpawn = true;
        despawnTimer -= subtract;
    }
}