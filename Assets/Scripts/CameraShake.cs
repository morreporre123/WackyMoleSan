using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    //Anton

    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;      //Saves original pos so the camera knows where to reset to

        float elapsed = 0.0f;       //Checks so the amount of time the camera has shaken does not pass the maximum time it is allowed to shake

        while(elapsed < duration)       //As long as the elapsed time is shorter than the duration...
        {
            float x = Random.Range(-1f, 1f) * magnitude;        //Shake on the x axis times the magnitude
            float y = Random.Range(-1f, 1f) * magnitude;        //Shake on the y axis times the magnitude

            transform.localPosition = new Vector3(x, y, originalPos.z);     //Set the shaking position

            elapsed += Time.deltaTime;      //Update "elapsed" in realtime

            yield return null;      //Waits until the next frame to start again
        }

        transform.localPosition = originalPos;      //Resets original position
    }

}
