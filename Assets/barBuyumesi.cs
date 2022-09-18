using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barBuyumesi : MonoBehaviour {
    public GameObject oyunTopu;
    public GameObject pembeTop;
    private topBuyumesi yonetici;
    

    // Use this for initialization
    void Start () {
        StartCoroutine("ObjeyiKimildat");
  

        
    }
    public IEnumerator ObjeyiKimildat()
    {
        float kimildamaSuresi = 13f; // Objeyi 3 saniyede hareket ettir
        float gecenSure = 0f;

        Vector2 mevcutKonum = transform.position;
        Vector2 hedefKonum = new Vector2(transform.position.x + 2.8f, transform.position.y);

        while (gecenSure < kimildamaSuresi) // Henüz kimildamaSuresi kadar süre geçmediği müddetçe bu kodu çalıştır
        {

            gecenSure += Time.deltaTime; // gecenSure her saniye 1 artar
            transform.position = Vector3.Lerp(mevcutKonum, hedefKonum, gecenSure / kimildamaSuresi); // Objenin konumunu mevcutKonum ile hedefKonum arasında oynat



            yield return null; // 1 frame bekle (yumuşak hareket için objenin konumunu bir anda değil, frame frame değiştirmeliyiz)}

        }

        // kimildamaSuresi kadar süre geçti, objenin hedefKonum'a tam oturduğundan emin ol
        transform.position = hedefKonum;
        yokEt();

    }

    public void yokEt()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

    }
    public IEnumerator bekle()
    {
        yield return new WaitForSeconds(10);
        eskiHalineDon();
    }



    // Update is called once per frame
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopAllCoroutines();
        yokEt();
        Vector3 temp = oyunTopu.transform.localScale;
        Vector3 bastakiBar = oyunTopu.transform.localScale;
        
        temp.x = 0.2f;
        temp.y = 0.2f;
        
        oyunTopu.transform.localScale= temp;
        StartCoroutine("bekle");

    }
    public void eskiHalineDon()
    {
        Vector3 bastakiBar = new Vector3(0.05576f, 0.05576f, 1f);
        oyunTopu.transform.localScale = bastakiBar;
        

    }

}
