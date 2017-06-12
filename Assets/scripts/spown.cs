using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spown : MonoBehaviour {
	public static int count;//生成した敵の数をカウント
	public static int spo;//今場にいる敵の数
	public GameObject[] enemy;//敵オブジェクト
	public GameObject[] aitem;//アイテムオブジェクト
	public int rnd;//乱数用変数
	public static bool coin;//コイン
	public static int aitemu=0;//アイテム番号

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
			//敵を生成（10回に1回ボスを出現）
			if (count % 10 == 0 && count !=0) 
			{
				//ボスを生成
				Instantiate(enemy[1], transform.position + new Vector3(0, 0, 0), Quaternion.identity);

			}
			else
			{
				//enemyを生成
				Instantiate(enemy[0], transform.position + new Vector3(0, 0, 0), Quaternion.identity);
			}
			//生成した敵をカウント
			count++;
			//ランダムな値を代入
			rnd = Random.Range(1,6);
			//ランダムな値が2で割り切れるならアイテムを生成
			if (rnd % 2 == 0 )
			{
				//アイテム生成
				Instantiate(aitem[Random.Range(0, aitem.Length)], transform.position, Quaternion.identity);
			}
		}
		if (coin == true)
		{
			coin = false;
			//コインを消費してアイテムを生成
			Instantiate(aitem[aitemu], transform.position, Quaternion.identity);
		}

	}
}
