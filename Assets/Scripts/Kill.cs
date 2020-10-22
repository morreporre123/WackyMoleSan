using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    //Anton
    private Player player;
    private moleSpawnerv2 spawner;

    public CameraShake cameraShake;

    public float shakeDur, shakeMag, timer;
    float pointTimer = 100;
    private bool timerStart = false;
    public bool isMole;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<moleSpawnerv2>();
    }
    private void OnMouseDown()
    {
        if (isMole)
        {
            timerStart = true;  
            //StartCoroutine(cameraShake.Shake(shakeDur, shakeMag));
        }
        else
        {
            FindObjectOfType<powerUpHandler>().randomPu(GetComponent<SpriteRenderer>()); // Lucas
        }
    }
    private void Update()
    {
        pointTimer -= Time.deltaTime * (100 / spawner.spawnMultiplier);
        if (timerStart)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 0.15f)
        {
            timer = 0;
            timerStart = false;
            player.scorePoints += pointTimer;
            Destroy(gameObject);
        }
    }
}