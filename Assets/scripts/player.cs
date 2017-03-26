using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    characterstatus status;//ステータス
    public GameObject SE;//音源
    public GameObject you=null;//射程内のオブジェクト保存用
    public GameObject gameover;//ゲームオーバーの画像用オブジェクト
    bool one;//死亡時に一度だけ呼び出す用の変数
    public int attackcount;//攻撃間隔カウント
    public int rand;//乱数
	public GameObject kougeki;

	void Start () {
        status = transform.root.GetComponent<characterstatus>();//ステータス獲得
        one = true;//初期化
	}

	void Update () {
        //ゲーム開始状態のとき動作
        if (manager.gameok == true)
        {

            //スペースで攻撃
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //射程内に敵がいたら動作
                if (you != null)
                {
					attack ();
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
            if (attackcount >= status.attackspeed)
            {
				//カウントリセット
				attackcount = 0;
				attack ();
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

        //剣をとったら自分の攻撃力を1増加
        if (coll.gameObject.CompareTag("ken"))
        {
            SE.GetComponent<SE>().koukaon(1);
            status.power++;
        }

        //盾をとったら自分の防御力を1増加
        if (coll.gameObject.CompareTag("tate"))
        {
            SE.GetComponent<SE>().koukaon(1);
            status.defense+=2;
        }

		//クリスタルをとったら攻撃速度を1増加
		if (coll.gameObject.CompareTag("kurisutaru"))
		{
			SE.GetComponent<SE>().koukaon(1);
			status.attackspeed--;
			if (status.attackspeed < 10) {
				status.attackspeed = 10;
			}
		} 

        //コインをとったらコインのカウントを1増加
        if (coll.gameObject.CompareTag("koin"))
        {
            SE.GetComponent<SE>().koukaon(9);
			manager.coin+=Random.Range(1,3);
        } 
    }

	//攻撃
	void attack()
	{
		//ダメージ計算
		//攻撃エフェクト
		Instantiate(kougeki, you.transform.position+new Vector3(Random.Range(-0.5f,1f),Random.Range(-0.5f,1f),-0.1f), Quaternion.identity);
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
		//乱数
		rand = Random.Range(3, 8);
		//攻撃音
		SE.GetComponent<SE>().koukaon(rand);
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
