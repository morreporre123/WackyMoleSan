using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
    //Nummer för vilket vapen man väljer, 1 är fist, 2 är chainsaw och 3 är gun //Mauritz
    public int weaponnumber;

    public Sprite fist;
    public Sprite chainsaw;
    public Sprite gun;
    public SpriteRenderer cs; //CursorSprite

    private Vector3 cursorposition;
    private float mouseX;
    private float mouseY;

    public Camera cam;



    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.mousePosition.x;
        mouseY = Input.mousePosition.y;
        cursorposition = Input.mousePosition;
        cursorposition.z = 0;
        cursorposition = cam.ScreenToWorldPoint(cursorposition);

        cs.transform.position = cursorposition;

        if (weaponnumber == 1)
        {
            cs.sprite = fist;

        }
        if(weaponnumber == 2)
        {
            cs.sprite = chainsaw;

        }
        if(weaponnumber == 3)
        {
            cs.sprite = gun;

        }
    }
    #region Funkytions
    public void Fist()
    {
        weaponnumber = 1;
        SceneManager.LoadScene("Testscen123");
    }

    public void Chainsaw()
    {
        weaponnumber = 2;
        SceneManager.LoadScene("Testscen123");
    }

    public void Gun()
    {
        weaponnumber = 3;
        SceneManager.LoadScene("Testscen123");
    }
    #endregion

}
