using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    //Anton

    public CameraShake cameraShake;

    public float shakeDur, shakeMag, timer;

    private bool timerStart = false;


    private void OnMouseDown()
    {
        Player.scorePoints++;
        timerStart = true;
        StartCoroutine(cameraShake.Shake(shakeDur, shakeMag));
    }

    private void Update()
    {
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
