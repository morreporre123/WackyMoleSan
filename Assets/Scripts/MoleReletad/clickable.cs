using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickable : MonoBehaviour
{
    //Lucas & Anton
    Player prefs;
    [SerializeField] Animator anim;
    [SerializeField] CameraShake camShake;
    bool start, isDead = false;
    float timeToLive, o_timeToLive, maxPoints, timer;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        prefs = FindObjectOfType<Player>();
    }
    private void Update()
    {
        timer += Time.deltaTime;

        anim.SetFloat("SpawnYes", timer);

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
        isDead = true;
        StartCoroutine(camShake.Shake(0.1f, 0.3f));
        anim.SetBool("IsDead", true);
        Destroy(gameObject, 0.3f);
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
