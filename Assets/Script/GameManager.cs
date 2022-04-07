using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameOver { get; private set; } = false;
    public Transform spawnLocation;
    
    float spawnInterval = 0.8f;
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
       
    }
    public void TogglePause()
    {
        // vérifier si le temps est en pause ou non
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
    }
    
}
