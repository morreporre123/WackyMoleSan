using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUpObject", order = 1)]
public class powerUpScriptable : ScriptableObject // Lucas
{
    public float duration;
    public Sprite powerUpSprite;
    public enum Type
    {
        empty,
        freeze,
        Hej,
        test
    }
    public Type type;
}