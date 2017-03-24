using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    characterstatus status;//ステータス
    public GameObject SE;//音源
    public GameObject you=null;//射程内のオブジェクト保存用
    public GameObject gameover;//ゲームオーバーの画像用オブジェクト
    bool one;//死亡時に一度だけ呼び出す用の変数
    public GameObject kougeki;//攻撃画像
    public int attackcount;//攻撃間隔カウント
    public int rand;//乱数

	void Start () {
        status = transform.root.GetComponent<characterstatus>();//ステータス獲得
        one = true;//初期化
	}

	void Update () {
        //ゲーム開始状態のとき動作
        if (manager.gameok == true)
        {


            /*
             //移動
            // 右・左
            float x = Input.GetAxisRaw("Horizontal");
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) && status.died==false)
            {
                transform.Translate(status.speed * x, 0, 0);
            }
            //左に行き過ぎないようにする
            if (transform.position.x < -8)
            {
                transform.Translate(status.speed, 0, 0);
            }
            //右に行き過ぎないようにする
            if (transform.position.x >= 8)
            {
                transform.Translate(status.speed * -1, 0, 0);
            }
            */


            //スペースで攻撃
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //攻撃画像生成
                Instantiate(kougeki, transform.position + new Vector3(0.8f, -0.2f, 0f), Quaternion.identity);
                //射程内に敵がいたら動作
                if (you != null)
                {
                    //相手にダメージを与える
                    you.GetComponent<characterstatus>().HP = you.GetComponent<characterstatus>().HP - status.power;
                    //乱数
                    rand = Random.Range(3, 8);
                    //攻撃音
                    SE.GetComponent<SE>().koukaon(rand);


                }
            }

            //HPが0になったら一度だけ動作
            if (status.HP <= 0)
            {
                if (one)
                {
                    //ゲームオーバー画像生成
                    Instantiate(gameover, new Vector3(0, 0, 0), Quaternion.identity);
                    //managerのgameoverをtrueにする
                    manager.gameov = true;
                    //一度きり解除
                    one = false;
                    //プレイヤーを消滅
                    Destroy(gameObject);
                }
            }

            //射程内に敵がいたら攻撃カウント動作
            if (you != null)
            {
                attackcount++;
            }


            //攻撃カウントが攻撃間隔に達したら動作
            if (attackcount == status.attackspeed)
            {
                //ダメージ計算

                //与えるダメージ
                int damage;
                //自分の攻撃力から相手の防御力を引く
                damage = status.power - you.GetComponent<characterstatus>().defense;
                //与えるダメージが1以下にならないようにする
                if (damage < 1)
                {
                    damage = 1;
                }
                //相手にダメージ
                you.GetComponent<characterstatus>().HP = you.GetComponent<characterstatus>().HP - damage;
                //カウントリセット
                attackcount = 0;
                //乱数
                rand = Random.Range(3, 8);
                //攻撃音
                SE.GetComponent<SE>().koukaon(rand);

            }
            //最大値を超えないように
            if (status.HP > status.MAXHP)
            {
                status.HP = status.MAXHP;//HP
            }

            if (status.MP > status.MAXMP)
            {
                status.MP = status.MAXMP;//MP
            }
        }
	}
    //プレイヤーに何か触れたとき
    void OnCollisionEnter2D(Collision2D coll)
    {
        /*
        //敵が触れたら自分に敵の攻撃力ぶんダメージを受けてノックバックする
        if (coll.gameObject.CompareTag("enemy"))
        {
            transform.Translate(-0.5f, 0, 0);
            status.HP -= you.GetComponent<characterstatus>().power;
        }
        */

        //HP回復アイテムをとったら最大HPの10％回復
        if (coll.gameObject.CompareTag("hp"))
        {
            SE.GetComponent<SE>().koukaon(1);
            status.HP += status.MAXHP / 10;
        }

        //MP回復アイテムをとったら最大MPの10％回復
        if (coll.gameObject.CompareTag("mp"))
        {
            SE.GetComponent<SE>().koukaon(1);
            status.MP += status.MAXMP / 10;
        }

        //攻撃力増加アイテムをとったら自分の攻撃力を1増加
        if (coll.gameObject.CompareTag("ken"))
        {
            SE.GetComponent<SE>().koukaon(1);
            status.power++;
        }

        //防御力増加アイテムをとったら自分の防御力を1増加
        if (coll.gameObject.CompareTag("tate"))
        {
            SE.GetComponent<SE>().koukaon(1);
            status.defense+=2;
        }

        //コインをとったらコインのカウントをを1増加
        if (coll.gameObject.CompareTag("koin"))
        {
            SE.GetComponent<SE>().koukaon(1);
            manager.coin++;
        } 
    }
    //プレイヤーの射程内に敵がいるとき
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy") || other.gameObject.CompareTag("bosu"))
        {
            you = other.transform.root.gameObject;//射程範囲の相手を記憶
        }
    }

    //射程内から敵がいなくなったとき
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy") || other.gameObject.CompareTag("bosu"))
        {
            you = null;//相手から離れたらnullを代入
        }
    }
}
