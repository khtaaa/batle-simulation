using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspown : MonoBehaviour {
    public static int count;//生成した敵の数をカウント
    public static int spo;//今場にいる敵の数
    public GameObject[] enemy;//敵オブジェクト
    public GameObject[] aitem;//アイテムオブジェクト
    public int rnd;//乱数用変数
    public static bool coin;
    public static int aitemu=0;

	void Start () {
        //初期化
        count = 0;
        spo = 0;
        coin = false;
        aitemu = 0;
		
	}

	void Update () {
        //フィールドに敵が1対も居ないなら敵をスポーン
        if (spo < 1)
        {
            //敵を生成
            if (count % 10 == 0 && count !=0) 
            {
                Instantiate(enemy[1], transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(enemy[0], transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            }
            //生成した敵をカウント
            count++;
            //ランダムな値を代入
            rnd = Random.Range(1,6);
            //ランダムな値が2で割り切れるならアイテムを生成
            if (rnd % 2 == 0 )
            {
                Instantiate(aitem[Random.Range(0, aitem.Length)], transform.position, Quaternion.identity);
            }
        }
        if (coin == true)
        {
            coin = false;
            Instantiate(aitem[aitemu], transform.position, Quaternion.identity);
        }
		
	}
}
