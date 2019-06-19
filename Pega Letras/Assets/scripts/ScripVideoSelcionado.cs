using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
public class ScripVideoSelcionado : MonoBehaviour
{
    public RawImage imagem;
    public List<VideoPlayer> Videos = new List<VideoPlayer>();
    public static VideoPlayer vide;
    public static int indexVideo;
    private VideoPlayer videoSelecionado;
    public configHitoria historia;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        videoSelecionado = Videos[indexVideo];
        for (int i = 0; i < Videos.Count; i++)
        {
            Videos[i].enabled = false;
        }
        videoSelecionado.EnableAudioTrack(0, true);
        videoSelecionado.enabled = true;
        videoSelecionado.Prepare();
        WaitForSeconds waitforSeconds = new WaitForSeconds(1);
        while (!videoSelecionado.isPrepared)
        {
            yield return waitforSeconds;
            break;

        }
        
        videoSelecionado.EnableAudioTrack(1, true);
        imagem.texture = videoSelecionado.texture;
        videoSelecionado.Play();
        
    }

    void Update()
    {
        if (videoSelecionado.isPaused || Input.GetKeyDown(KeyCode.KeypadEnter))
            historia.jogar();

    }

}
