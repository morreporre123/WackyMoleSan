﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    #region Variables

    private float currentMoles = 0;

    public GameObject[] moles;
    public GameObject[] spawnPoints;

    #endregion

    void Update()
    {
        if (currentMoles <= 3 && Input.GetKeyDown(KeyCode.Space))
        {
            SpawnMoles();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            currentMoles--;
        }
    }

    void SpawnMoles()
    {
        Instantiate(moles[Random.Range(0, moles.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
        currentMoles++;
    }

}
