using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public turretPlacementUI turretPlacementUI;
    public turretPlacement turretPlacement;
    public bool coutAchat { get { return turretToBuild != null; } }
    //public bool AvoirArgent { get { return Player.argent >= turretToBuild.cost; } }

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    


    

    public turretPlacement SelectturretPlacement { get; private set; }
    public object turretToBuild { get; private set; }

    public void SelectTurret()
    {
        if (SelectturretPlacement == turretPlacement)
        {
            DeselectNode();
            return;
        }


        turretToBuild = null;


    }
        public void DeselectNode()
        {
            //selectedNode = null;
            turretPlacementUI.Hide();
        }

   }

