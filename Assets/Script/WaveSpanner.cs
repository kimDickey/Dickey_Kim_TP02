using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpanner : MonoBehaviour
{
    public static int EnnemiesEnVie = 0;
    public GameObject ennemie;
    public float tempsAvantWave = 5f;
    private int waveIndex = 0;
    public Text txtNbVague;
    private float decompte = 2f;
    public UIManager manager;
    public Wave[] waves;
    private object spawnPoint;

    void Update()
    {
        // si les ennemies sont encore en vie continuer la vague
        if (EnnemiesEnVie > 0)
        {
            return;
        }

        
        // si le décompte est en bas de 0 démarrer la coroutine
        if (decompte <= 0f)
        {
            StartCoroutine(Spawner());
            decompte = tempsAvantWave;
            return;
        }
        // deccompte moins le temps
        decompte -= Time.deltaTime;

        decompte = Mathf.Clamp(decompte, 0f, Mathf.Infinity);
        // affiche le decompte avant la nouvelle vague dans le bon format
        txtNbVague.text = string.Format("{0:00.00}", decompte);

    }
    IEnumerator Spawner()
    {
       //index de la vague
        Wave wave = waves[waveIndex];

        EnnemiesEnVie = wave.count;
        
        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnnemies(wave.ennemie);
            // temps avant la seconde vague
            yield return new WaitForSeconds(1f / wave.rate);
        }

        waveIndex++;


    }
    void SpawnEnnemies(GameObject ennemie)
    {
       
    }
}
   
