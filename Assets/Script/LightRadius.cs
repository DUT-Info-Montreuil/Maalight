using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightRadius : MonoBehaviour
{
    public float timeStart = 60;
    UnityEngine.Experimental.Rendering.Universal.Light2D playerLight;
    // Start is called before the first frame update
    void Start()
    {
        playerLight = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }

    void FixedUpdate()
    {
        if (playerLight.pointLightOuterRadius > 1)
        {
           playerLight.pointLightOuterRadius -= 0.09766666666f/60;
           if (playerLight.pointLightOuterRadius < 2f)
           {
               playerLight.color = Color.red;
           }
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
}
