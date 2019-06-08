using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configHitoria : MonoBehaviour
{
    private GestureListener gestureListener;    
    // Start is called before the first frame update
    void Start()
    {
        gestureListener = Camera.main.GetComponent<GestureListener>();
    }

    // Update is called once per frame
    void Update()
    {

        KinectManager kinectManager = KinectManager.Instance;
        if ((!kinectManager || !kinectManager.IsInitialized() || !kinectManager.IsUserDetected()))
            return;

         if (gestureListener.IsWave())
            voltar();
        else if (gestureListener.IsJump())
            jogar();              
    }

    void voltar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
        this.enabled = false;
        Destroy(this);
    }

    public void jogar()
    {
        if (ScripVideoSelcionado.indexVideo == 0)
            UnityEngine.SceneManagement.SceneManager.LoadScene("a_porta");
        else if (ScripVideoSelcionado.indexVideo == 1)
            UnityEngine.SceneManagement.SceneManager.LoadScene("trem");
        else if (ScripVideoSelcionado.indexVideo == 2)
            UnityEngine.SceneManagement.SceneManager.LoadScene("casa_ruinas");
        else if (ScripVideoSelcionado.indexVideo == 3)
            UnityEngine.SceneManagement.SceneManager.LoadScene("bolhas");
        else if (ScripVideoSelcionado.indexVideo == 4)
            UnityEngine.SceneManagement.SceneManager.LoadScene("ocorrencia");
        else if (ScripVideoSelcionado.indexVideo == 5)
            UnityEngine.SceneManagement.SceneManager.LoadScene("paciente");

        this.enabled = false;
        Destroy(this);
    }
}
