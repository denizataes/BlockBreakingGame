using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topPatlamasi : MonoBehaviour {
    public GameObject top1;
    public GameObject top2;
    public GameObject top3;
   
    int sayac = 0;
    // Use this for initialization
  
    void Start () {
        top1.GetComponent<SpriteRenderer>().enabled = false;
        top1.GetComponent<CircleCollider2D>().enabled = false;
        top2.GetComponent<SpriteRenderer>().enabled = false;
        top2.GetComponent<CircleCollider2D>().enabled = false;
        top3.GetComponent<SpriteRenderer>().enabled = false;
        top3.GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(ObjeyiKimildat());
    }

    private IEnumerator ObjeyiKimildat()
    {
        float kimildamaSuresi = 13f; // Objeyi 3 saniyede hareket ettir
        float gecenSure = 0f;

        Vector2 mevcutKonum = transform.position;
        Vector2 hedefKonum = new Vector2(transform.position.x+2.8f,transform.position.y);

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


    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopAllCoroutines();
        top1.GetComponent<SpriteRenderer>().enabled = true;
        top1.GetComponent<CircleCollider2D>().enabled = true;
        top2.GetComponent<SpriteRenderer>().enabled = true;
        top2.GetComponent<CircleCollider2D>().enabled = true;
        top3.GetComponent<SpriteRenderer>().enabled = true;
        top3.GetComponent<CircleCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        top1.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -10f, 0);
        top2.GetComponent<Rigidbody2D>().velocity = new Vector3(5f, 9f, 0);
        top3.GetComponent<Rigidbody2D>().velocity = new Vector3(6f, 8f, 0);
    }

    private void yokEt()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

    }
   
        
       

    }

