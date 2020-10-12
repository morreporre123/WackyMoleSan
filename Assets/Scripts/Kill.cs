using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public CameraShake cameraShake;

    public float shakeDur;
    public float shakeMag;


    private void OnMouseDown()
    {
        Destroy(gameObject);
        StartCoroutine(cameraShake.Shake(shakeDur, shakeMag));
    }

}
