using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public static event Action OnDisableCubes;
    public static event Action OnEnableCubes;

    bool isCubesDestroyed = false;
    void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {   
            if(!isCubesDestroyed)
                DisableCubes();

            else
                EnableCubes();  
        }     
    }

    void DisableCubes()
    {
        OnDisableCubes?.Invoke();
        isCubesDestroyed = true;
    }

    void EnableCubes()
    {
        OnEnableCubes?.Invoke();
        isCubesDestroyed = false;
    }
}
