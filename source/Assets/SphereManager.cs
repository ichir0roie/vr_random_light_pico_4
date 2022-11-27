using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
// using System;

public class LightManager : MonoBehaviour
{

    List<GameObject> gameObjectList;

    float update;

    void Awake()
    {
        Debug.Log("Awake");

        // lightManager = new GameObject("lightManager");
        gameObjectList = new List<GameObject>();
        update = 0.0f;



    }

    IEnumerator Start()
    {
        Debug.Log("Start1");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Start2");
    }

    void Update()
    {
        update += Time.deltaTime;
        if (update > 3.0f)
        {
            Debug.Log("update");
            update = 0.0f;
            Debug.Log("Update");
            addLight();

            if (gameObjectList.Count > 5)
            {
                GameObject light = gameObjectList[0];
                Destroy(light);
                gameObjectList.RemoveAt(0);
            }
        }
    }

    public void addLight()
    {
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        // Set color and position
        // lightComp.color = new Color(
        //     Random.Range(0, 255),
        //     Random.Range(0, 255),
        //     Random.Range(0, 255)
        // );
        // lightComp.range = 15;

        // Material m = new Material();
        // var r = go.GetComponent<Renderer>();
        // r.material.SetColor(
        //     "_Color",
        //     new Color(
        //         Random.Range(0, 255),
        //         Random.Range(0, 255),
        //         Random.Range(0, 255)
        //     )
        // );
        // Set the position (or any transform property)
        go.transform.position = new Vector3(
            Random.Range(300, 300),
            Random.Range(300, 300),
            Random.Range(50, 499)
            );

        gameObjectList.Add(go);
    }

}
