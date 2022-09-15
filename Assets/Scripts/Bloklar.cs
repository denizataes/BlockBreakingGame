using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloklar : MonoBehaviour {
    private int can;
    private int vurulmaSayisi;
    private SahneKontrolu yonetici;
    public Sprite[] blokGorunumleri;
    public static int kirilabilirSayisi = 0;
    bool KirilabilirMi;
    public GameObject efekt;
 



    // Use this for initialization
    void Start() {
       
        KirilabilirMi = (this.tag == "kirilabilir");
        if(KirilabilirMi)
        {
            kirilabilirSayisi++;
        }
        vurulmaSayisi = 0;
        yonetici = GameObject.FindObjectOfType<SahneKontrolu>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        sesCikar();
        VurulmaKontrolu();
    }
    public void sesCikar()
    {
        GetComponent<AudioSource>().Play();
    }
    public void VurulmaKontrolu()
    {
         int can;
        can = blokGorunumleri.Length + 1;
    vurulmaSayisi++;



        if (vurulmaSayisi >= can)
        {
            kirilabilirSayisi--;
            GameObject efektimiz = Instantiate(efekt, gameObject.transform.position, Quaternion.identity) as GameObject ;
            if (efektimiz != null)
            {
                     efektimiz.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
                //  Destroy(gameObject);// küçük harf olması demek şuan sahip oolduğumuz obje , büyük harf olsaydı hiyerarşideki obje olurdu
                GetComponent<SpriteRenderer>().enabled = false;

                GetComponent<BoxCollider2D>().enabled = false;
            }
            yonetici.bloklarinYokOlmasi();
           
        }
        else
        {
            BlokGoruntusunuDegistir();
        }
    }
  

    
public void BlokGoruntusunuDegistir()
{

        this.GetComponent<SpriteRenderer>().sprite = blokGorunumleri[vurulmaSayisi - 1];
}
    public void SonrakiSahne()
    {
        yonetici.sonrakiSahne();
    }
   

}
