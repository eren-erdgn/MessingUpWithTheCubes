using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{   
    
    void OnEnable() 
    {   
        CubeManager.OnEnableCubes += EnableMe;
        CubeManager.OnDisableCubes += DisableMe;
    }
    void OnDestroy() 
    {   
        CubeManager.OnEnableCubes -= EnableMe;
        CubeManager.OnDisableCubes -= DisableMe;
    }
    
    void DisableMe()
    {
        gameObject.SetActive(false);
    }
    void EnableMe()
    {   
        gameObject.SetActive(true);
    }
    
}
