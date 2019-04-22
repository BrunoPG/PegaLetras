using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ScriptVideo : MonoBehaviour
{

    public RawImage imagem;
    //public Button botao;
    public VideoPlayer videoplayer;
    //public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        videoplayer.Prepare();
        WaitForSeconds waitforSeconds = new WaitForSeconds(1);
        while (!videoplayer.isPrepared)
        {
            yield return waitforSeconds;
            break;

        }
        //botao.image.GetComponent("RawImage") = videoplayer.texture;
        imagem.texture = videoplayer.texture;
        videoplayer.Play();
       // audio.Play();
    }   

    
}
