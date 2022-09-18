﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasarisizSonuclanma : MonoBehaviour {

    private SahneKontrolu yonetici;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "oyunTopu")
        {
            yonetici = GameObject.FindObjectOfType<SahneKontrolu>();
            yonetici.SahneyeYonel("Kaybetme");
        }
    }
        
  

}
