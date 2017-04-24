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

	public void mae()
	{
		setumei_text.setumei--;
		if (setumei_text.setumei < 0) {
			setumei_text.setumei = 0;
		}
	}

	public void sukippu()
	{
		Application.LoadLevel("battle");
	}
}
