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
        pusType = powerUpScriptable.Type.empty;
    }
    public void randomPu(SpriteRenderer sr)
    {
        pusType = powerUpScriptable.Type.empty;
        current = sTypes[Random.Range(0, sTypes.Length)];
        current.powerUpSprite = sr.sprite;
        StartCoroutine(startPowerUp(current.duration, current.type));
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
                
                break;
            case powerUpScriptable.Type.Anton:
                
                break;
        }
    }
    public IEnumerator startPowerUp(float t, powerUpScriptable.Type type)
    {
        pusType = type;
        yield return new WaitForSeconds(t);
        pusType = powerUpScriptable.Type.empty;
    } 
}