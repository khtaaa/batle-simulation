using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {
    characterstatus status;

	void Start () {
        status = transform.root.GetComponent<characterstatus>();
	}

    public class attackinfo
    {
        public int attackP;
        public Transform attacker;
    }

    attackinfo getattackinfo()
    {
        attackinfo attackinfo = new attackinfo();
        attackinfo.attackP = status.power;
        attackinfo.attacker = transform.root;
        return attackinfo;
    }
}
