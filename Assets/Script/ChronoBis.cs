using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoBis : MonoBehaviour
{
    float time;
    public float TimerInterval = 5f;
    float tick;

    void Awake()
    {
        time = (int)Time.time;
        tick = TimerInterval;   
    }

    // Update is called once per frame
    void Update()
    {
        // GetComponent<Text>().text = time.ToString();
        // time = (int)Time.time;
        // if(time==tick)
        // {
        //     tick = time + TimerInterval;
        //     //Executer le code du timer
        //     print("timer");
        // }
    }
}
