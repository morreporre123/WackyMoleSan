using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUpObject", order = 1)]
public class powerUpScriptable : ScriptableObject // Lucas
{
    public float duration;
    public Sprite powerUpSprite;
    public enum Type   //alla olika typer av powerups
    {
        empty,
        doublePoints,
        moreLife,
        slowerSpawnTime
    }
    public Type type;
}