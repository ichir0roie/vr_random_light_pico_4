using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Main
{

    // static LightManager lightManager;
    static GameObject gameObject;

    static Main()
    {
        Debug.Log("Up and running");
        gameObject = new GameObject("lights");
        gameObject.AddComponent<LightManager>();
    }



}
