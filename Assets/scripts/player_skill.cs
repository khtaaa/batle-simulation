using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_skill : MonoBehaviour {
    characterstatus status;
    public GameObject SE;//音源

	// Use this for initialization
	void Start () {
        status = transform.root.gameObject.GetComponent<characterstatus>();
	}
	
	// Update is called once per frame
	void Update () {
        if (status.HP<85 && status.MP > 10 && Input.GetKeyDown(KeyCode.Keypad1))
        {
            status.MP -= 10;
            status.HP += 15;
            SE.GetComponent<SE>().koukaon(8);
        }
	}
}
