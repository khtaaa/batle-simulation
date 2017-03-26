using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
    characterstatus status;//ステータス
    public GameObject coin;//ドロップアイテム
    public float XX;//プレイヤーのＸ座標
    public int syatei;//射程
    public int attackcount;//攻撃間隔のカウント
    public GameObject you=null;//射程内のオブジェクト保存用
    public int rand;//乱数
    public GameObject SE;//音源
	public GameObject bgm;//BGM
    public string tagu;//敵のタグ
	public GameObject kougeki;

	// Use this for initialization
	void Start () {
        tagu = transform.tag;
        SE = GameObject.Find("SE");//SEオブジェクト獲得
		bgm = GameObject.Find("BGM");//BGMオブジェクト獲得
        status = transform.root.GetComponent<characterstatus>();//ステータス獲得
        XX = GameObject.Find("player").transform.position.x;//プレイヤーの座標獲得
        enemyspown.spo++;//enemyspownのエネミーの数をプラス
        if (tagu == "enemy")
        {
			status.MAXHP *= manager.wave;//MAXHPを増加
            status.HP = status.MAXHP;//HPをMAXHPと同じにする
			status.power *= manager.wave*2;//攻撃力増加
			status.defense *= manager.wave;//防御力増加
            int syatei=1;//射程
        }
        if (tagu == "bosu")
        {
			bgm.GetComponent<bgm>().bgmbgm(1);
			status.MAXHP *= manager.wave * 5;//MAXHPを増加
            status.HP = status.MAXHP;//HPをMAXHPと同じにする
			status.power *= manager.wave*3;//攻撃力増加
			status.defense *= manager.wave*2;//防御力増加
            int syatei=50;//射程
        }
	}
	
	void Update () {
        //ゲーム開始状態のとき動作
        if (manager.gameok == true)
        {
            //敵が空白のとき意外起動
            if (you != null)
            {
                //XXに射程内のプレイヤーのx座標を入れる
                XX = you.transform.position.x;
                //攻撃カウント動作
                attackcount++;
            }
            //XXが自分の射程外なら追尾
            if (XX < transform.position.x - syatei)
            {
                transform.Translate(-0.05f, 0, 0);
            }
            //HPが0になったら
            if (status.HP <= 0)
            {
				SE.GetComponent<SE>().koukaon(10);
                enemyspown.spo--;//enemyspownのエネミーの数をマイナス
                //ドロップアイテムを生成
                if (tagu == "enemy")
                {
                        Instantiate(coin, transform.position, Quaternion.identity);
                }
                if (tagu == "bosu")
                {
					bgm.GetComponent<bgm>().bgmbgm(0);
                    Instantiate(coin, new Vector3(0,-1,0), Quaternion.identity);
                    Instantiate(coin, new Vector3(0, -1, 0), Quaternion.identity);
                    Instantiate(coin, new Vector3(0, -1, 0), Quaternion.identity);
					//次のwaveにする
					manager.wave++;
					manager.waveok = true;
                }

                //自分を消滅
                Destroy(gameObject);
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

            //攻撃カウントが攻撃間隔の値になったら動作
            if (attackcount == status.attackspeed)
            {
                //ダメージ計算
				//攻撃エフェクト
				Instantiate(kougeki, you.transform.position+new Vector3(Random.Range(-0.5f,1f),Random.Range(-0.5f,1f),-0.1f), Quaternion.identity);
                //与えるダメージ
                int damage;
                //自分の攻撃から相手の防御力を引く
                damage = status.power - you.GetComponent<characterstatus>().defense;
                //攻撃力が1以下のならないようにする
                if (damage < 1)
                {
                    damage = 1;
                }
                //相手にダメージ
                you.GetComponent<characterstatus>().HP = you.GetComponent<characterstatus>().HP - damage;
                //カウントリセット
                attackcount = 0;
                //乱数
                rand = Random.Range(3,8);
                //攻撃音
                SE.GetComponent<SE>().koukaon(rand);
            }

        }
	}

    //射程範囲内にプレイヤーが入ったら動作
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            you = other.transform.root.gameObject;//射程範囲の相手を記憶
        }
    }

    //射程内からプレイヤーが消えたら動作
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            you = null;//相手から離れたらnullを代入
        }
    }
   
}
