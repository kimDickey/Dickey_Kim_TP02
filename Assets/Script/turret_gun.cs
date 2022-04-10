using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_gun : turret
{
    public Transform gun;
    public Transform tirDebut;
    private Ennemis1 ennemies;
    public TrailRenderer trajectoireEffet;
    public Transform pivot;
    public Rigidbody projectile;
    public float range = 25.0f;
    private bool inRange = false;
    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        ennemies = FindObjectOfType<Ennemis1>();
        InvokeRepeating("UpdateDistance", 0.5f, 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = GameObject.FindGameObjectWithTag("body").transform.position - tirDebut.transform.position;
        Vector3 rotation = Quaternion.LookRotation(relativePos).eulerAngles;
        pivot.transform.localEulerAngles = new Vector3(-90f, 0f, GameObject.FindGameObjectWithTag("body").transform.position.z);
        gun.transform.localEulerAngles = new Vector3(GameObject.FindGameObjectWithTag("body").transform.position.z, 0f, 0f);
    }
    protected override void Shoot()
    {

    }
    void UpdateDistance()
    {
        GameObject[] ennemies = GameObject.FindGameObjectsWithTag("ennemiestag");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in ennemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {

                //pivot.transform.LookAt(relativePos);
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            ray.origin = tirDebut.position;
            ray.direction = tirDebut.forward;
            var tracer = Instantiate(trajectoireEffet, ray.origin, Quaternion.identity);
            tracer.AddPosition(ray.origin);
            if (Physics.Linecast(tirDebut.position, nearestEnemy.transform.position, out hit))
            {
                tracer.transform.position = hit.point;
                






            }
        }
    }
}
