using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CokluTopHataGiderme : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (transform.position.y > 9.45f)
        {
            Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, -3f));
        }
        else
        {
            Vector2 ufakSapma = new Vector2(Random.Range(0f, 0.3f), Random.Range(0f, 0.3f));
            GetComponent<Rigidbody2D>().velocity += ufakSapma;
        }
    }
}
