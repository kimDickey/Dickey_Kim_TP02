using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class turretPlacement : MonoBehaviour
{

	public Vector3 positionOffset;
	public GameObject turret;
	public GameObject prefabTurretBomb;
	public GameObject prefabTurretGun;
	public GameObject prefabTurretFreeze;
	

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance;
	}
	public GameObject prefab;
	public int cost;

	public int Vente()
	{
		return cost / 2;
	}

	public Vector3 GetBuildPosition()
	{
		return transform.position + positionOffset;
	}

	void OnMouseDown()
	{
		if (EventSystem.current.IsPointerOverGameObject())
			return;

		if (turret != null)
		{
			//buildManager.SelectTurret(this);
			return;
		}

		//if (!buildManager.CanBuild)
			return;

	}

	void ConstruireTurret()
	{
		if (Player.argent < cost)
		{
			Debug.Log("Vous avez pas asser d'argent");
			return;
		}

		Player.argent -= cost;

		




	}


	public void venteTurret()
	{
		Player.argent += Vente();

	
	}

	void ActiverBomb()
    {

    }
	void ActiverGun()
	{

	}
	void ActiverFreeze()
	{

	}


}
