using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    //Anton

    #region Variables

    public GameObject[] moles;
    public GameObject[] spawnPoints;
    public bool[] filled;

    #endregion

    void Update()
    {
        int number = Random.Range(0, spawnPoints.Length);

        if (Input.GetKeyDown(KeyCode.Space) && !filled[number])
        {
            SpawnMoles(number);
        }
    }

    void SpawnMoles(int index)
    {
        Instantiate(moles[Random.Range(0, moles.Length)], spawnPoints[index].transform.position, Quaternion.identity);                //Instantiates a random mole on a random spawnpoint
        filled[index] = true;
    }
}
