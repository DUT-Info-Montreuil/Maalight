using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightShutDown : MonoBehaviour
{
    public GameObject LightScene;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COLLISION");
       LightScene.SetActive(false);
    }
}
