using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text txtTime;
    public bool isGameOver { get; private set; } = false;
    public Transform spawnLocation;
    public GameObject prefabEnnemi1;
    float timer;
    float spawnInterval = 0.8f;
    public GameObject txtGameOver;
    //permet de savoir si le jeu est en pause ou non




    // const float gameDuration = ;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(TogglePause);
    }

    // Update is called once per frame
    void Update()
    {
        // debuter le timer
        timer += 1;
        // calculer le temps en minutes:secondes
        txtTime.text = string.Format("{0:0}:{1:00}", Mathf.Floor(timer / 60), Mathf.Floor(timer) % 60);
    }
    public void TogglePause()
    {
        // vérifier si le temps est en pause ou non
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
    }
    // Fin de la partie
    public void GameOver()
    {
        isGameOver = true;
        txtGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

}
