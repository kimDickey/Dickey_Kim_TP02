using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

	void Awake()
	{
		if (instance != null)
		{
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	public GameObject buildEffect;
	public GameObject sellEffect;

	
	public turretPlacementUI turretPlacementUI;
	public turretPlacement turretPlacement;

	public bool CanBuild { get { return turretToBuild != null; } }
	//public bool HasMoney { get { return Player.argent >= turretToBuild.cost; } }

    public turretPlacement SelectturretPlacement { get; private set; }
    public object turretToBuild { get; private set; }

    public void SelectTurret()
	{
		if (SelectturretPlacement == turretPlacement)
		{
			DeselectNode();
			return;
		}

		//SelectturretPlacement = node;
		turretToBuild = null;

		//turretPlacementUI.SetTarget(node);
	}

	public void DeselectNode()
	{
		//selectedNode = null;
		turretPlacementUI.Hide();
	}

	public void SelectTurretToBuild()
	{
		//turretToBuild = turret;
		DeselectNode();
	}

	public  turretPlacement GetTurretToBuild()
	{
		//return turretToBuild;
	}
}
