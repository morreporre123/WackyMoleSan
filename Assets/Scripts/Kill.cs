using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public CameraShake cameraShake;

    public float shakeDur;
    public float shakeMag;

    public float timer;

    private bool timerStart = false;


    private void OnMouseDown()
    {
        if(gameObject.tag == "Mole")
        {
            StartCoroutine(cameraShake.Shake(shakeDur, shakeMag));
            timerStart = true;
        }
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
