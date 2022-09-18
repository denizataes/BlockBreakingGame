using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {


    public static bool oyunDurdu = false;
    
    public void pauseGame()
    {
        if (oyunDurdu)
        {
            Time.timeScale = 1;
            oyunDurdu = false;

        }
        else
        {
            Time.timeScale = 0;
            oyunDurdu = true;
        }
    }
    
	

}
