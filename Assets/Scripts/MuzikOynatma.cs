using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikOynatma : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject);//müzik oynatıcısı objesi ekran load olsada bitmesin demek


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
