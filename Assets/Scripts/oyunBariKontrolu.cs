using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunBariKontrolu : MonoBehaviour {
    public bool otomatikOynama = false;
    private oyunTopuKontrolu oyundakiTop;

	// Use this for initialization
	void Start () {
        oyundakiTop = GameObject.FindObjectOfType<oyunTopuKontrolu>();
	}
	
	// Update is called once per frame
	void Update () {
        if(otomatikOynama)
        {
            otomatikHareket();
        }
        else
        faremizleHareket();



	}
    void faremizleHareket()
    {
        Vector3 oyunBariKonumu = new Vector3(0f, this.transform.position.y, 0f);
        float mouseKonumX = (Input.mousePosition.x / Screen.width*5)-2.5f;
        oyunBariKonumu.x = Mathf.Clamp(mouseKonumX, -1.9f, 1.9f); // oyun barı ekranın dışına çıkmaması için x leri yazdım
        this.transform.position = oyunBariKonumu;
    }
    void otomatikHareket()
    {
        Vector3 oyunBariKonumu = new Vector3(0f, this.transform.position.y, 0f);
        Vector3 topunKonumu = oyundakiTop.transform.position;
        oyunBariKonumu.x = Mathf.Clamp(topunKonumu.x, -1.9f, 1.9f); // oyun barı ekranın dışına çıkmaması için x leri yazdım
        this.transform.position = oyunBariKonumu;

    }
}
