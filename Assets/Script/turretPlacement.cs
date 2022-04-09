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
	public Button btnGun;

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
			buildManager.SelectNode(this);
			return;
		}

		if (!buildManager.CanBuild)
			return;

		Cons(buildManager.GetTurretToBuild());
	}

	void ConstruireTurret()
	{
		if (Player.argent < cost)
		{
			Debug.Log("Vous avez pas asser d'argent");
			return;
		}

		Player.argent -= cost;

		GameObject _turret = (GameObject)Instantiate(TurretBomb.prefab, GetBuildPosition(), Quaternion.identity);
		turret = _turret;




	}


	public void venteTurret()
	{
		Player.argent += Vente();

		GameObject effect = (GameObject)Instantiate(buildManager.sellEffect, GetBuildPosition(), Quaternion.identity);
		Destroy(effect, 5f);
		Destroy(turret);

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
