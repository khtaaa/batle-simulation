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
		if (manager.gameok == true) {
			if (transform.tag == "kaihuku") {
				if (ST.GetComponent<characterstatus> ().MP > 10 && ST.GetComponent<characterstatus> ().HP <= ST.GetComponent<characterstatus> ().MAXHP / 10 * 9) {
					ST.GetComponent<characterstatus> ().MP -= 10;
					ST.GetComponent<characterstatus> ().HP += ST.GetComponent<characterstatus> ().MAXHP / 10;
					SE.GetComponent<SE> ().koukaon (8);
				}
			}

			if (transform.tag == "tateup") {
				if (ST.GetComponent<characterstatus> ().MP > 15) {
					ST.GetComponent<characterstatus> ().MP -= 15;
					manager.tateup += 600;
					SE.GetComponent<SE> ().koukaon (8);
				}
			}

			if (transform.tag == "kenup") {
				if (ST.GetComponent<characterstatus> ().MP > 15) {
					ST.GetComponent<characterstatus> ().MP -= 15;
					manager.kenup += 600;
					SE.GetComponent<SE> ().koukaon (8);
				}
			}
		}
	}
}
