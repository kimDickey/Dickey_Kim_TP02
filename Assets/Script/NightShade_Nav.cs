using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class NightShade_Nav : Ennemis1
{
    Animator animatorNightShade;
    
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

    void Start()
    {
        //speed = Startspeed;
        //sante = santeDepart;
    }

    // Update is called once per frame
    void Update()
    {
        // sa marche pas a moitiée
        //var navArea= NavMeshHit();
        //agent.SamplePathPosition(-1, 0.0f, out navArea);
        //if (navArea.mask != 1)
           // isFloating = true;
        //else
            //isFloating = false;
    }
     protected  override void TakeDommage()
    {
        sante -= amount;
        // pas encore faite la barre de vie ... 
        //barreDeVie.fillAmount = sante / santeDepart;
    }

    private object NavMeshHit()
    {
        throw new System.NotImplementedException();
    }

     public  override void Die()
    {
        isDead = true;
        Player.argent += valeur;
        WaveSpanner.EnnemiesEnVie--;
        Destroy(gameObject);

    }
}
