using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    //Anton
    private Player player;
    private MoleSpawner spawner;

    public CameraShake cameraShake;

    public bool hasClicked;

    private float points;
    private void Awake()
    {
        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<MoleSpawner>();
    }
    private void OnMouseDown()
    {
        hasClicked = true;
        //spawner.despawn(gameObject, true, points);
    }
    private void Update()
    {
        //points = Mathf.Lerp(points, 0, spawnedFrom.despawnTimer);
    }
}