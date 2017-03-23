using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    characterstatus status;
    public float attack = 5;
    public int dameage;
    public GameObject you;
    public GameObject gameover;
    bool one;
    public GameObject kougeki;


	// Use this for initialization
	void Start () {
        status = transform.root.GetComponent<characterstatus>();
        one = true;
	}

	// Update is called once per frame
	void Update () {
        if (manager.gameok == true)
        {
            //移動
            // 右・左
            /*
            float x = Input.GetAxisRaw("Horizontal");
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) && status.died==false)
            {
                transform.Translate(status.speed * x, 0, 0);
            }
            */

            if (transform.position.x < -8)
            {
                transform.Translate(status.speed, 0, 0);
            }

            if (transform.position.x >= 8)
            {
                transform.Translate(status.speed * -1, 0, 0);
            }
            //攻撃
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(kougeki, transform.position + new Vector3(0.8f, -0.2f, 0f), Quaternion.identity);
                if (you != null)
                {
                    you.GetComponent<characterstatus>().HP = you.GetComponent<characterstatus>().HP - status.power;//相手のＨＰを減少

                }
            }

            if (status.HP <= 0)
            {
                status.died = true;
            }

            //死亡
            if (status.died == true)
            {
                if (one)
                {
                    Instantiate(gameover, new Vector3(0, 0, 0), Quaternion.identity);
                    manager.gameov = true;
                    one = false;
                    Destroy(gameObject);
                }
            }
        }
	}
    //敵に衝突したとき
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("enemy"))
        {
            transform.Translate(-0.5f, 0, 0);//ノックバック
            status.HP -= you.GetComponent<characterstatus>().power;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {

            you = other.transform.root.gameObject;//射程範囲の相手を記憶
            
        }

    }

    //オブジェクトが離れた時
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            you = null;//相手から離れたらnullを代入
        }
    }



    

}
