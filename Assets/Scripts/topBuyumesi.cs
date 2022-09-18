using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topBuyumesi : MonoBehaviour
{
    public GameObject oyunBari;
    public GameObject PembeTop;




    void Start()
    {

        StartCoroutine("ObjeyiKimildat");
    }


    private void yokEt()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

    }


    private IEnumerator ObjeyiKimildat()
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
    private IEnumerator bekle()
    {
        yield return new WaitForSeconds(10);
        eskiHalineDon();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopAllCoroutines();
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        Vector3 temp = oyunBari.transform.localScale;
        Vector3 bastakiBar = oyunBari.transform.localScale;
        
        temp.x = 0.7f;
        oyunBari.transform.localScale = temp;
        StartCoroutine("bekle");

    }

    private void eskiHalineDon()
    {
        Vector3 bastakiBar = new Vector3(0.44663f, 0.45203f, 1f);
        oyunBari.transform.localScale = bastakiBar;

    }
}


