  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_positions : MonoBehaviour
{
    // Start is called before the first frame update
    private float InstantiationTimer = 2f;
    // Start is called before the first frame update
    private string letras = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        InstantiationTimer -= Time.deltaTime;
        if (InstantiationTimer <= 0)
        {
            int index = Random.Range(0, this.letras.Length);
            float eixoX = Random.Range(-1.0f, 1.0f);
            float eixoY = Random.Range(2f, 4f);
            char let = this.letras[index];
            GameObject letra = (GameObject) Instantiate(Resources.Load("Prefabs/" + let), new Vector3( eixoX, eixoY, this.transform.position.z+15f), Quaternion.identity);
            letra.transform.Rotate(0, 180, 0);
            InstantiationTimer = 2f;
        }
        
    }
}

