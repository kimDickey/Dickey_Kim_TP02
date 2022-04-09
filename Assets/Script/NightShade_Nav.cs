using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class NightShade_Nav : ennemis
{
    Animator animatorNightShade;
    NavMeshAgent agent;
    public bool isFloating;
    NavMeshHit hit;
    public float speed;
    float Startspeed = 30f;
    float santeDepart = 200;
    private float sante;
    public Image barreDeVie;
    bool isDead = false;
    float amount;
     int valeur = 200;

    new void Start()
    {
        speed = Startspeed;
        sante = santeDepart;
    }

    // Update is called once per frame
    void Update()
    {
        //var navArea= NavMeshHit();
        //agent.SamplePathPosition(-1, 0.0f, out navArea);
        //if (navArea.mask != 1)
           // isFloating = true;
        //else
            //isFloating = false;
    }
    void TakeDommage()
    {
        sante -= amount;
        //barreDeVie.fillAmount = sante / santeDepart;
    }

    private object NavMeshHit()
    {
        throw new System.NotImplementedException();
    }

     void Die()
    {
        isDead = true;
        Player.argent += valeur;
        WaveSpanner.EnnemiesEnVie--;
        Destroy(gameObject);

    }
}
