using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    //Anton
    private moleSpawnerv2 spawner;
    public CameraShake cameraShake;

    public float shakeDur, shakeMag, timer;
    float pointTimer = 100;
    private bool timerStart = false;
    public bool isMole;
    private void OnMouseDown()
    {
        if (isMole)
        {
            Player.scorePoints += pointTimer * 100;
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
        pointTimer -= Time.deltaTime;
        if (timerStart)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 0.15f)
        {
            timer = 0;
            timerStart = false;
            Destroy(gameObject);
        }
    }
}