using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class turretPlacementUI : MonoBehaviour
{
    public bool uiIsOpen = false;
    private object turretBuyMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (!ManagerUI.uiIsOpen)
        {
            turretBuyMenu.SetActive(true);
            ManagerUI.uiIsOpen = true;
        }
    }
    void EnleverOr()
    {

    }
    void PlacerTurret()
    {

    }
    void ActiverUI()
    {

    }
    void EnleverTurret()
    {

    }


}
