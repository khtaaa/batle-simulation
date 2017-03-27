using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour {
	public GameObject ST;
	public GameObject SE;
	// Use this for initialization
	void Start () {
		ST= GameObject.Find ("player");
		SE = GameObject.Find ("SE");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		//ST= GameObject.Find ("player");
		if (transform.tag=="kaihuku")
		{
			if (ST.GetComponent<characterstatus>().MP>10 && ST.GetComponent<characterstatus>().HP<=ST.GetComponent<characterstatus>().MAXHP/10*9)
			{
				ST.GetComponent<characterstatus>().MP -= 10;
				ST.GetComponent<characterstatus>().HP += ST.GetComponent<characterstatus>().MAXHP / 10;
				SE.GetComponent<SE> ().koukaon (8);
			}
		}
	}
}
