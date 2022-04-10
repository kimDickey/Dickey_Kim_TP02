using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Ennemis1 : MonoBehaviour
{
    NavMeshAgent agent; 
    public void Start()
    {
        /// mon navMeshAgent marche je sais pas pourquoi :(
        agent = GetComponent<NavMeshAgent>();
        Vector3 newDestination = new Vector3(16.4f, 0f, -52.8f);
        agent.SetDestination(newDestination);
        Debug.Log(agent);
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected abstract void TakeDommage();
    public abstract void Die();
}
