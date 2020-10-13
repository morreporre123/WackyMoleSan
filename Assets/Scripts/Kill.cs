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
        if(gameObject.tag == "Mole")
        {
            StartCoroutine(cameraShake.Shake(shakeDur, shakeMag));
            Destroy(gameObject);
        }
    }
}
