using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class LightLife : MonoBehaviour
{
    UnityEngine.Experimental.Rendering.Universal.Light2D lamp;
    // Start is called before the first frame update
    void Start()
    {
        lamp = GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         
        LightRadius.instance.aggrandirHallo();
    }
}
