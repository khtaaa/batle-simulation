using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoartext : MonoBehaviour {
	public static int scoar=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scoar == 0) {
			this.GetComponent<Text> ().text = "no scoar";
		} else {
			this.GetComponent<Text>().text = "highscoar:" + scoar + "wave";
		}
		
	}
}
