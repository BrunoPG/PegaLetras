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
            pular();       
    }

    void voltar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuInicial");
        this.enabled = false;
        Destroy(this);
    }

    void pular()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("scenelettters");

        this.enabled = false;
        Destroy(this);
    }
}
