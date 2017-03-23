using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aitem_hp : MonoBehaviour {
    public GameObject you;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-0.05f, 0, 0);
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            you = coll.transform.root.gameObject;
            you.GetComponent<characterstatus>().HP = you.GetComponent<characterstatus>().HP + (you.GetComponent<characterstatus>().HP/10);
            Destroy(gameObject);
        }
    }
}
