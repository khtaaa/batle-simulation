using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kougeki_sc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//生成されて3秒で削除
        Destroy(gameObject, .3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
