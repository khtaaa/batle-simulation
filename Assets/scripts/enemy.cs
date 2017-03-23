using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    characterstatus status;
    public float XX;
    public int syatei = 1;
    public int dameage;
    public int attacktime=90;
    public int attackcount;
    public GameObject you=null;

	// Use this for initialization
	void Start () {
        status = transform.root.GetComponent<characterstatus>();
        XX = GameObject.Find("player").transform.position.x;
        enemyspown.spo++;
        status.MAXHP = status.MAXHP + enemyspown.count * 5;
        status.HP = status.MAXHP;
        status.power = status.power + enemyspown.count;
	}
	
	// Update is called once per frame
	void Update () {
        if (manager.gameok == true)
        {
            if (you != null)
            {
                XX = you.transform.position.x;
            }
            if (XX < transform.position.x - syatei)
            {
                transform.Translate(-0.05f, 0, 0);
            }

            if (status.HP == 0)
            {
                enemyspown.spo--;

                Destroy(gameObject);
            }
            if (you != null)
            {
                attackcount++;
            }

            if (attackcount == attacktime)
            {
                attackcount = 0;
                //相手にダメージ
                you.GetComponent<characterstatus>().HP = you.GetComponent<characterstatus>().HP - status.power;

            }

        }
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            you = other.transform.root.gameObject;//射程範囲の相手を記憶

        }


    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            you = null;//相手から離れたらnullを代入
        }
    }
   
}
