using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text txtTime;
    public bool isGameOver { get; private set; } = false;
    public Transform spawnLocation;
    public GameObject prefabEnnemi1;
    int timer;
    float timerDebut;
    float spawnInterval = 0.8f;
    public GameObject txtGameOver;
    public Button btnPause;
    public Button btnPlay;
    
    public Text txtPointDeVie;
    public bool isPaused = false;
    int nbVie = 5;


    // const float gameDuration = ;
    // Start is called before the first frame update
    void Start()
    {
        // temps du timer départ
        timerDebut = 0;
        //
        btnPause.onClick.AddListener(PauseTime);
        btnPlay.onClick.AddListener(ResumePartie);
       
    }

    // Update is called once per frame
    void Update()
    {
        // debuter le timer
        timerDebut = timerDebut + Time.deltaTime;
        TimeSpan timer = TimeSpan.FromSeconds(timerDebut);
        // calculer le temps en minutes:secondes
        txtTime.text = timer.ToString(@"mm\:ss\:ff");
    }
    
    void PauseTime()
    {
        // vérifier si le temps est en pause ou non
        Time.timeScale = 0f;
        isPaused = true;

    }

    void ResumePartie()
    {
        Time.timeScale = 1f;
        isPaused = false; 
    }

    public void PointDeViePerdu()
    {
        nbVie -= 1;
        txtPointDeVie.text = nbVie.ToString();
        if( nbVie == 0)
        {
            GameOver();
        }

    }
    // Fin de la partie
    public void GameOver()
    {
        isGameOver = true;
        txtGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

}
