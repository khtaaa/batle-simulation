using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    characterstatus status;
    public float XX;
    public int syatei = 1;
    public static float enemy_hp=100;
    public static float enemy_maxhp;

	// Use this for initialization
	void Start () {
        status = transform.root.GetComponent<characterstatus>();
        XX = GameObject.Find("player").transform.position.x;
        enemy_maxhp = enemy_hp;
	}
	
	// Update is called once per frame
	void Update () {
        XX = GameObject.Find("player").transform.position.x;
        if (XX < transform.position.x-syatei)
        {
            transform.Translate(-0.05f, 0, 0);
        }

        if (enemy_hp <= 0)
        {
            enemy_hp = 0;
        }

        if (enemy_hp > enemy_maxhp)
        {
            enemy_hp = enemy_maxhp;
        }

        if (enemy_hp == 0)
        {
            Destroy(gameObject);
        }


	}

    //敵に衝突したとき
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemy_hp = enemy_hp - 10;

        }
    }

    void damage(attack.attackinfo attackinfo)
    {
        status.HP = status.HP - attackinfo.attackP;

    }
   
}
