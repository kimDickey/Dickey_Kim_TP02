using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ennemis : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject prefabEnnemi1;
   
    int sante;
    int argent;
   
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Vector3 newDestination = new Vector3(16.4f, 0f, -52.8f);
        agent.SetDestination(newDestination);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Dommage()
    {
        sante--;

        if (sante < 1)
            Die();
    }
    public void Die()
    {

        CancelInvoke("UpdateDestination");
        Destroy(gameObject);
    }
}
