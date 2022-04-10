using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
	public GameObject particles;
	public Transform Ennemies;
	private Warrok_Nav warrok;
	private NightShade_Nav nightShade;
	private Skeeleton_Nav skeeleton;


    private void Start()
    {
		nightShade = FindObjectOfType<NightShade_Nav>();
		warrok = FindObjectOfType<Warrok_Nav>();
		skeeleton = FindObjectOfType<Skeeleton_Nav>();
	}

    private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "ennemiestag" && GameObject.Find("skeleton Variant"))
		{
			skeeleton.Die();
		}
		if (other.gameObject.tag == "ennemiestag" && GameObject.Find("nightShade Variant"))
		{
			nightShade.Die();
		}
		else
        {
			warrok.Die();
        }
	}
}
