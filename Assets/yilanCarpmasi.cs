using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yilanCarpmasi : MonoBehaviour {
   public GameObject gorunmezTop;
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        Vector2 ufakSapma1 = new Vector2(0, 10f);
       gorunmezTop.GetComponent<Rigidbody2D>().velocity += ufakSapma1;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        gorunmezTop.GetComponent<CircleCollider2D>().isTrigger = false;
    }
    
    
        


    
}
