using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool shouldMove = false;
    Vector3 p;
    // Start is called before the first frame update
    void Start()
    {
        p = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < 0)
        {
            this.transform.position = p;
        }
        transform.position += Vector3.back * 1 / 8;
        //Vector3.forward.(3);
        //transform.Translate(Vector3.back * 1 / 4);


    }

    void OnCollisionEnter(Collision col)
    {
       
        this.shouldMove = true;

    }
}