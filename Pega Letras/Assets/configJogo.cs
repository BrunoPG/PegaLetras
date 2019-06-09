using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configJogo : MonoBehaviour
{
    public bool pause;
    public AudioSource certo, errado, somAmbiente, ganhou, perdeu;
    public Material PErro, PAcerto;
    public bool trocaImg;
    public List<string> letrasFaltantes;
    public float timerLetras = 0;
    // Start is called before the first frame update
    void Start()
    {
        letrasFaltantes = new List<string>();
        if (timerLetras == 0)
        {
            timerLetras = 0.05f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pause) return;
        if (!somAmbiente.isPlaying)
        {
            somAmbiente.Play();
        }       
    }

    public void PlayErrou()
    {
        if  (!pause)
             errado.Play();
    }

    public void PlayAcertou()
    {
        if (!pause)
            certo.Play();
    }

    

}
