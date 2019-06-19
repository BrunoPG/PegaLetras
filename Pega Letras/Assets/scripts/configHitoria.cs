using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

         //if (gestureListener.IsWave())
         //   voltar();
        //else if (gestureListener.IsJump())
        //    jogar();              
    }

    void voltar()
    {
        SceneManager.LoadScene(0);
        Destroy(GetComponent<Camera>().gameObject);
    }

    public void jogar()
    {
        if (ScripVideoSelcionado.indexVideo == 0)
            SceneManager.LoadScene(2);
        else if (ScripVideoSelcionado.indexVideo == 1)
            SceneManager.LoadScene(3);
        else if (ScripVideoSelcionado.indexVideo == 2)
            SceneManager.LoadScene(4);
        else if (ScripVideoSelcionado.indexVideo == 3)
            SceneManager.LoadScene(5);
        else if (ScripVideoSelcionado.indexVideo == 4)
            SceneManager.LoadScene(6);
        else if (ScripVideoSelcionado.indexVideo == 5)
            SceneManager.LoadScene(7);
        
        Destroy(GetComponent<Camera>().gameObject);
    }
}
