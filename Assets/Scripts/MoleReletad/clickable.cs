using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class clickable : MonoBehaviour
{
    //Lucas & Anton
    Player prefs;
    [SerializeField] Animator anim;
    CameraShake camShake;
    bool start, isDead = false;
    public bool isMole;

    private powerUpHandler powerUp;

    float timeToLive, o_timeToLive, maxPoints, timer, pointmultiplier;
    private void Start()
    {
        powerUp = FindObjectOfType<powerUpHandler>();
        camShake = FindObjectOfType<CameraShake>();
        anim = GetComponent<Animator>();
    }
    private void Awake()
    {
        prefs = FindObjectOfType<Player>();
    }
    private void Update()
    {
        if(anim != null)
        {
            timer += Time.deltaTime;
            anim.SetFloat("SpawnYes", timer);
        }
        if (start) // när skriptet startar så startar timern...
        {
            timeToLive -= Time.deltaTime;
        }
        if(timeToLive <= 0) // när timern når noll så...
        {
            Destroy(gameObject);    //Raderar objektet skriptet sitter på, Lucas
            if (isMole)
            {
                prefs.lives--; // sänker antalet liv med 1, Lucas
            }
        }
    }
    private void OnMouseDown()      //Metod för att märka när spelaren klickar på objektet, Lucas
    {
        if (!isDead)       //En if sats för att man inte ska kunna klicka två gånger på samma mole, Lucas
        {
            isDead = true;
            if (isMole)
            {
                anim.SetBool("IsDead", true);
                Destroy(gameObject, 0.3f);  //Raderar objektet skriptet sitter på efter 0.3 sekunder, Lucas
                prefs.scorePoints += pointmultiplier * (timeToLive / o_timeToLive) * maxPoints;   //adderar poäng baserat på hur långt tid det har gått innan man klickar, Lucas
                StartCoroutine(camShake.Shake(0.1f, 0.3f));
            }
            if(!isMole)
            {
                powerUp.randomPu();
                Destroy(gameObject);
            }
        }
    }
    public void live(float t, float maxP, float pX) // Lucas
    {
        timeToLive = t; o_timeToLive = t; // sätter variablerna till tiden som kommer med metoden, Lucas
        maxPoints = maxP; 
        start = true;
        pointmultiplier = pX;
    }
}