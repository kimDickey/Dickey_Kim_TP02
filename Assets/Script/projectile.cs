using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
	public GameObject particles;
	private Transform target;
	public Transform Ennemies;
	public float speed = 70f;

	public int damage = 50;

	public float explosionRadius = 0f;
	

	

	// Update is called once per frame
	void Update()
	{

		if (target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;
		float distanceThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
		transform.LookAt(target);

	}

	void HitTarget()
	{
		GameObject effectIns = (GameObject)Instantiate(particles, transform.position, transform.rotation);
		Destroy(effectIns, 5f);

		if (explosionRadius > 0f)
		{
			Explode();
		}
		else
		{
			//Damage(target);
		}

		Destroy(gameObject);
	}

	void Explode()
	{
		Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
		foreach (Collider collider in colliders)
		{
			if (collider.tag == "ennemis")
			{
				//Damage(collider.transform);
			}
		}
	}

	void Damage()
	{
		//Ennemies e = Ennemies.GetComponent<ennemis>();

		//if (e != null)
		{
			//e.TakeDamage(damage);
		}
	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, explosionRadius);
	}
	// Start is called before the first frame update
	void Start()
	{

	}

  }
