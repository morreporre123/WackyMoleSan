using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpHandler : MonoBehaviour // Lucas
{
    #region Default values
    public MoleSpawner spawner;
    private float defSpawnrate, defSubtract, defTimer;
    #endregion

    public powerUpScriptable[] sTypes;
    powerUpScriptable current;
    powerUpScriptable.Type pusType;
    private void Start()
    {
        defSpawnrate = spawner.spawnrate; defSubtract = spawner.subtract; defTimer = spawner.timer;
    }
    public void execute()
    {
        pusType = powerUpScriptable.Type.empty;
        current = sTypes[Random.Range(0, sTypes.Length)];
        //powerUpImage.Sprite = currentPowerUp.Sprite;
        StartCoroutine(puDuration(current.duration, current.type));
    }
    private void Update()
    {
        switch (pusType)
        {
            default:
            case powerUpScriptable.Type.empty:
                spawner.spawnrate = defSpawnrate;
                break;
            case powerUpScriptable.Type.freeze:
                //insert changed values
                break;
        }
    }
    IEnumerator puDuration(float t, powerUpScriptable.Type type)
    {
        pusType = type;
        yield return new WaitForSeconds(t);
        pusType = powerUpScriptable.Type.empty;
    } 
}