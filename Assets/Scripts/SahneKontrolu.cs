using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneKontrolu : MonoBehaviour {
    private static int   oncekiSahne = 0;

    public void sonrakiSahne()
    {

        int mevcutSahneninIndeksi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(mevcutSahneninIndeksi+1);

    }
    public void SahneyeYonel(string sahneIsmi)
    {
        oncekiSahne = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sahneIsmi);
    }
    public void oyunSahnesineYonel()
    {
        SceneManager.LoadScene(0);
        Bloklar.kirilabilirSayisi = 0;

    }
    public void menuSahnesineYonel()
    {
        
        SceneManager.LoadScene(0);
        
    }
    public void oyundanCik()
    {
        Application.Quit();

    }
    public void bloklarinYokOlmasi()
    {
        if(Bloklar.kirilabilirSayisi <=0)
        sonrakiSahne();
    }
    public void oncekiSahneyeGit()
    {
        SceneManager.LoadScene(oncekiSahne);
        Bloklar.kirilabilirSayisi = 0;
    }
    public void ayniSahneyiTekrarla()
    {
        int suankiSahne = SceneManager.GetActiveScene().buildIndex;
        
        SceneManager.LoadScene(suankiSahne);
        Bloklar.kirilabilirSayisi = 0;
    }
    
   


}
