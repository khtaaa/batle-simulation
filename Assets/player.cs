using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    characterstatus status;
    public static bool move = false;
    public float speed = 5;
    public bool life = true;
    public float attack = 5;


	// Use this for initialization
	void Start () {
        status = transform.root.GetComponent<characterstatus>();
        move = false;
        life = true;
        hp.HP = status.HP;
        hp.MAXHP = status.MAXHP;
        mp.MP = status.MP;
        mp.MAXMP = status.MAXMP;
	}
	
	// Update is called once per frame
	void Update () {
        //移動
        // 右・左
        float x = Input.GetAxisRaw("Horizontal");
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) && life==true)
        {
            transform.Translate(0.05f * x, 0, 0);
        }

        if (transform.position.x < -8)
        {
            transform.Translate(0.05f, 0, 0);
        }

        if (transform.position.x >= 8)
        {
            transform.Translate(-0.05f, 0, 0);
        }

        hp.HP = status.HP;
        hp.MAXHP = status.MAXHP;
        mp.MP = status.MP;
        mp.MAXMP = status.MAXMP;
		
	}

    void damage(attack.attackinfo attackinfo)
    {
        status.HP = status.HP - attackinfo.attackP;
    }
}
