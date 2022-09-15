﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunTopuKontrolu : MonoBehaviour {

    public oyunBariKontrolu oyunBari;
    private bool basladiMi =true; //true ya da false döndürür 
    private Vector3 topileBarArasindakiMesafe;
    int sayac = 1;


    // Use this for initialization
    void Start() {
        topileBarArasindakiMesafe = this.transform.position - oyunBari.transform.position;


    }

    // Update is called once per frame
    void Update() { 
   if(basladiMi)
        {
            this.transform.position = oyunBari.transform.position + topileBarArasindakiMesafe;

        }
   if(sayac==1)
   //if(Input.GetMouseButtonUp(0) )
   //    {
               
   //             basladiMi = false ;
           
   //         this.GetComponent<Rigidbody2D>().velocity = new Vector3(3f, 9f,0);
   //           sayac++;
   //   }

	
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));

        GetComponent<Rigidbody2D>().velocity += ufakSapma;

    }
   


}
