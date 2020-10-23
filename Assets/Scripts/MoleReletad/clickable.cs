using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable : MonoBehaviour
{
    Player prefs;
    bool start;
    float timeToLive, o_timeToLive, maxPoints;
    private void Awake()
    {
        prefs = FindObjectOfType<Player>();
    }
    private void Update()
    {
        if (start)
        {
            print("started timer");
            timeToLive -= Time.deltaTime;
        }
        if(timeToLive <= 0)
        {
            print("DEATH");
            prefs.lives--;
            print("despawn");
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        prefs.scorePoints += (timeToLive / o_timeToLive) * maxPoints;
    }
    public void live(float t, float maxP)
    {
        timeToLive = t; o_timeToLive = t;
        maxPoints = maxP;
        start = true;
        print("despawn time? " + timeToLive + "start? " + start);
    }
}
