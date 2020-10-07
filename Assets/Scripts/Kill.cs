using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    public CameraShake cameraShake;

    [SerializeField] float shakeDur;
    [SerializeField] float shakeMag;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(cameraShake.Shake(shakeDur, shakeMag));
        }
    }
}
