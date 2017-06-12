using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Text>().text = "x" + manager.coin;//所持コイン表示
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "x" + manager.coin;//所持コイン表示
	}
}
