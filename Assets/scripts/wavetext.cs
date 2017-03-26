using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wavetext : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.GetComponent<Text>().text = "WAVE" + manager.wave;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "WAVE" + manager.wave;		
	}
}
