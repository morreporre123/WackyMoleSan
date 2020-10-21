using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indMole : MonoBehaviour
{
    float timer = 2;
    public bool canSpawn = true;
    public IEnumerator spawn(GameObject mole)
    {
        GameObject newMole = Instantiate(mole, transform);
        canSpawn = false;
        yield return new WaitForSeconds(timer);
        if(newMole != null)
        {
            Destroy(newMole);
        }
        canSpawn = true;
    }
}