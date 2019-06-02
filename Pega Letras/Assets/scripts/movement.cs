using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool shouldMove = false;
    public config config;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (config.pause)
        {
            return;
        }
        if(!this.shouldMove)
            transform.localPosition += Vector3.back * 1 / 24;
        else
            transform.localPosition += Vector3.forward * 1 / 16;

    }

    void OnCollisionEnter(Collision col)
    {
       
        this.shouldMove = true;

    }
}