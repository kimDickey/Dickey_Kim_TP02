using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
public class NightShade_Nav : MonoBehaviour
{
    Animator animatorNightShade;
    NavMeshAgent agent;
    public bool isFloating;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var navArea = NavMeshHit();
        agent.SamplePathPosition(-1, 0.0f, out navArea);
        if (navArea.mask != 1)
            isFloating = true;
        else
            isFloating = false;
    }

    
}
