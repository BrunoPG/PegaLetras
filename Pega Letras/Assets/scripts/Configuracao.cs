using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuracao : MonoBehaviour
{
    public GameObject menu;
    static public bool pause;
    // Start is called before the first frame update
    void Start()
    {
       
       menu = Instantiate(menu, menu.transform.position, menu.transform.rotation) as GameObject;
       pauseGame(false);
    
        
    }

    void pauseGame(bool prPause)
    {
        pause = prPause;
        menu.SetActive(pause);

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame(!pause);

        }
        
    }
}
