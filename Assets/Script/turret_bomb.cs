using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret_bomb : turret
{
    public GameObject projectilBalle;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //appel le void Explode
        Invoke("Explode", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Shoot()
    {
        //si l'ennemi est proche tire
        //inflige dégat de zone et au ennemi
    }
    void Explode()
    {
        GetComponent<MeshRenderer>().enabled = false;

        Collider[] colliders = Physics.OverlapSphere(transform.position, 1.5f);

        foreach (var item in colliders)
        {
            if (item.name.Contains("ennemis"))
                item.GetComponent<ennemis>().Die();
        }
        // active la particule
        projectilBalle.SetActive(true);
        //détruit le gameObject
        Destroy(gameObject, 3f);
    }

    
}
