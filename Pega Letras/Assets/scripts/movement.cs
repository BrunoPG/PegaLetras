using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public bool shouldMove = false;
    public config config;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        if (mesh != null)
        {
            float r = Random.Range(0.0f, 1f);
            float g = Random.Range(0.0f, 1f);
            float b = Random.Range(0.0f, 1f);
            mesh.materials[0].color = new Color(r, g, b);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (config.trocaImg)
        {
            Destroy(this.GetComponent<GameObject>(),0.1f);
        }
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