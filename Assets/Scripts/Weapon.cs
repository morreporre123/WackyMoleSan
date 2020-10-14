using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour
{
    //Nummer för vilket vapen man väljer, 1 är fist, 2 är chainsaw och 3 är gun //Mauritz
    public int weaponnumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fist()
    {
        weaponnumber = 1;
        SceneManager.LoadScene(sceneBuildIndex: +1);
    }

    void Chainsaw()
    {
        weaponnumber = 2;
        SceneManager.LoadScene(sceneBuildIndex: +1);
    }

    void Gun()
    {
        weaponnumber = 3;
        SceneManager.LoadScene(sceneBuildIndex: +1);
    }


}
