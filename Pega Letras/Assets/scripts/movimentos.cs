using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;
public class movimentos : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    public void ClicarCena1()
    {         
       ScripVideoSelcionado.indexVideo = 0;       
       ChamaCenaMenuHistoria();               
    }

    public void ClicarCena2()
    {      
       ScripVideoSelcionado.indexVideo = 1;    
       ChamaCenaMenuHistoria();
    }

    public void ClicarCena3()
    {
        ScripVideoSelcionado.indexVideo = 2;
        ChamaCenaMenuHistoria();
    }


    public void ClicarCena4()
    {
        ScripVideoSelcionado.indexVideo = 3;
        ChamaCenaMenuHistoria();
    }


    public void ClicarCena5()
    {
        ScripVideoSelcionado.indexVideo = 4;
        ChamaCenaMenuHistoria();
    }

    public void ClicarCena6()
    {
        ScripVideoSelcionado.indexVideo = 5;
        ChamaCenaMenuHistoria();
    }
    public void ChamaCenaMenuHistoria()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        this.enabled = false;
        Destroy(this);
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}

