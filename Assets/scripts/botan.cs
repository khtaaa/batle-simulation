using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void tugi()
	{
		setumei_text.setumei++;
	}

	public void sukippu()
	{
		Application.LoadLevel("battle");
	}
}
