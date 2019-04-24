using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class movimentos : MonoBehaviour
{
    public Button botao1;
    public Button botao2;
    public Button botao3;
    public Button botao4;
    public Button botao5;
    public Button botao6;
    public Button sair;
    private Button selecionado;
    private GestureListener gestureListener;
    // Start is called before the first frame update
    void Start()
    {

        gestureListener = Camera.main.GetComponent<GestureListener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selecionado == null)
            selecionado = botao1;
        // dont run Update() if there is no user
        KinectManager kinectManager = KinectManager.Instance;
        if ((!kinectManager || !kinectManager.IsInitialized() || !kinectManager.IsUserDetected()))
            return;


        if (gestureListener.IsSwipeLeft())
            movimentaEsquerta();
        else if (gestureListener.IsSwipeRight())
            movimentaDireita();
        else if (gestureListener.IsSwipeDown())
            movimentaBaixo();
        else if (gestureListener.IsSwipeUp())
            movimentaCima();
        else if (gestureListener.IsClick())
            Clicar();        
        selecionado.Select();
                   
    }

    void movimentaCima()
    {
        if (selecionado == botao4)
            selecionado = botao1;
        else if (selecionado == botao5)
            selecionado = botao2;
        else if (selecionado == botao6)
            selecionado = botao3;
        else if (selecionado == sair)
            selecionado = botao6;              
    }
    void movimentaBaixo()
    {
        if (selecionado == botao1)
            selecionado = botao4;
        else if (selecionado == botao2)
            selecionado = botao5;
        else if (selecionado == botao3)
            selecionado = botao6;
        else if (selecionado == botao6)
            selecionado = sair;
        else if (selecionado == sair)
            selecionado = botao1;
    }

    void movimentaDireita()
    {
        if (selecionado == botao1)
            selecionado = botao2;
        else if (selecionado == botao2)
            selecionado = botao3;
        else if (selecionado == botao3)
            selecionado = botao4;
        else if (selecionado == botao4)
            selecionado = botao5;
        else if (selecionado == botao5)
            selecionado = botao6;
        else if (selecionado == botao6)
            selecionado = sair;

    }

    void movimentaEsquerta()
    {
        if (selecionado == botao2)
            selecionado = botao1;
        else if (selecionado == botao3)
            selecionado = botao2;
        else if (selecionado == botao4)
            selecionado = botao3;
        else if (selecionado == botao5)
            selecionado = botao4;
        else if (selecionado == botao6)
            selecionado = botao5;
        else if (selecionado == sair)
            selecionado = botao6;
    }

    public void Clicar()
    {

         if (selecionado == botao1)
            ScripVideoSelcionado.indexVideo = 0;
        else if (selecionado == botao2)
            ScripVideoSelcionado.indexVideo = 1;
        else if (selecionado == botao3)
            ScripVideoSelcionado.indexVideo = 2;
        else if (selecionado == botao4)
            ScripVideoSelcionado.indexVideo = 3;
        else if (selecionado == botao5)
            ScripVideoSelcionado.indexVideo = 4;
        else if (selecionado == botao6)
            ScripVideoSelcionado.indexVideo = 5;
        //ScripVideoSelcionado.vide = selecionado.GetComponent("VideoPlayer") as VideoPlayer;
        if (selecionado != null)
           ChamaCenaMenuHistoria();        
       
    }


    public void ChamaCenaMenuHistoria()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("Historia");
        this.enabled = false;
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}

