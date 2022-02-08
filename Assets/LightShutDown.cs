using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightShutDown : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D LightScene;
    // Start is called before the first frame update
    void Start()
    {
        LightScene = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        LightScene.intensity = 0;
    }
}
