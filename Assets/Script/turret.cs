using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class turret : MonoBehaviour
{
    
    float range = 25.0f;
    float dommages = 30f;
    int turretIndex;
    
    public Transform rotationSpeed;
    public float vitesseDeTir = 950.0f;
    public Transform target;
    Vector3 cible;
    public int coutBomb = 300;
    public int coutGun = 150;
    public int coutFreeze = 275;
    // Start is called before the first frame update
    void Start()
    {
        float random = Random.Range(1.0f, 2.0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RotationSurEnnemi()
    {
        Vector3 position = target.position - rotationSpeed.transform.position;
        Vector3 rotation = Quaternion.LookRotation(position).eulerAngles;
        rotationSpeed.transform.localEulerAngles = new Vector3(0, 0, rotation.y);
        transform.localEulerAngles = new Vector3(-90, 0, transform.localEulerAngles.z);
    }

    void dommage()
    {
        float dommageTour = Random.Range(10f, 15f);
       
    }

    protected abstract void Shoot();
}
