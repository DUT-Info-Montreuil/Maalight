using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightRadius : MonoBehaviour
{
    public float timeStart = 60;
    UnityEngine.Experimental.Rendering.Universal.Light2D playerLight;
    
    public static LightRadius instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de PlayerMovement dans la scène");
            return;
        }

        instance = this;
    }

    void Start()
    {
        playerLight = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }
    void FixedUpdate()
    {
        if (playerLight.pointLightOuterRadius > 1)
        {
           playerLight.pointLightOuterRadius -= 0.09766666666f/60; 
        } else
        {
            Die();
            return;
        }
    }
    void Die(){
         PlayerMovement.instance.animator.SetTrigger("Die");
         PlayerMovement.instance.enabled = false;
    }

    public void aggrandirHallo()
    {
        playerLight.pointLightOuterRadius += 0.09766666666f * 5;
    }
}
