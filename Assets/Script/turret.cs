using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class turret : MonoBehaviour
{
    float range;
    int domage;
    int turretIndex;
    public int cost;
    public float rotationSpeed;
    public float vitesseDeTir;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    abstract void Shoot();
}
