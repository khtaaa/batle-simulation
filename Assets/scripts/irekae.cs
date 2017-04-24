using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irekae : MonoBehaviour {
	public bool _irekae;
	public GameObject[] item;//アイテム
	public GameObject[] skill;//スキル
	public GameObject ST;//プレイヤーデータ
	public GameObject SE;//効果音
	public GameObject[] haikei;
	// Use this for initialization
	void Start () {
		_irekae = true;
		ST= GameObject.Find ("player");//STにプレイヤーを代入
		SE = GameObject.Find ("SE");//SEにSEを代入
	}
	
	// Update is called once per frame
	void Update () {
		if (manager.gameok == true) {
			//左ALTを押したらアイテムとスキルを入れ替え
			if (Input.GetKeyDown (KeyCode.LeftAlt)) {
				SE.GetComponent<SE> ().koukaon (11);
				_irekae = !_irekae;
			}
			if (_irekae == true) {
				//アイテムとスキルの背景入れ替え
				haikei [1].SetActive (false);
				haikei [0].SetActive (true);

				//アイテムをすべて表示
				for (int i = 0; i < item.Length; i++) {
					item [i].SetActive (true);
				}
				//スキルをすべて非表示
				for (int i = 0; i < skill.Length; i++) {
					skill [i].SetActive (false);
				}


				//コインが1枚以上のとき動作
				//アイテムクリックの召還処理
				//アイテムのキーボードでの召還処理
				if (manager.coin > 0) {
					if (Input.GetKeyDown (KeyCode.Alpha1)) {
						manager.coin--;//コインを減少
						enemyspown.aitemu = 0;
						enemyspown.coin = true;
					}

					if (Input.GetKeyDown (KeyCode.Alpha4)) {
						manager.coin--;
						enemyspown.aitemu = 1;
						enemyspown.coin = true;
					}

					if (Input.GetKeyDown (KeyCode.Alpha2)) {
						manager.coin--;
						enemyspown.aitemu = 2;
						enemyspown.coin = true;
					}

					if (Input.GetKeyDown (KeyCode.Alpha3)) {
						manager.coin--;
						enemyspown.aitemu = 3;
						enemyspown.coin = true;
					}

					if (Input.GetKeyDown (KeyCode.Alpha5)) {
						manager.coin--;
						enemyspown.aitemu = 4;
						enemyspown.coin = true;
					}
				}
			} else {
				//アイテムとスキルの背景入れ替え
				haikei [0].SetActive (false);
				haikei [1].SetActive (true);

				//アイテムをすべて非表示
				for (int i = 0; i < item.Length; i++) {
					item [i].SetActive (false);
				}
				//スキルをすべて表示
				for (int i = 0; i < skill.Length; i++) {
					skill [i].SetActive (true);
				}

				//スキル処理
				if (ST.GetComponent<characterstatus> ().MP > 10 && ST.GetComponent<characterstatus> ().HP <= ST.GetComponent<characterstatus> ().MAXHP / 10 * 9) {
					if (Input.GetKeyDown (KeyCode.Alpha1)) {
						ST.GetComponent<characterstatus> ().MP -= 10;
						ST.GetComponent<characterstatus> ().HP += ST.GetComponent<characterstatus> ().MAXHP / 10;
						SE.GetComponent<SE> ().koukaon (8);
					}
				}
				if (ST.GetComponent<characterstatus>().MP>15 )
				{
					if (Input.GetKeyDown (KeyCode.Alpha2)) {
						ST.GetComponent<characterstatus> ().MP -= 15;
						manager.tateup += 600;
						SE.GetComponent<SE> ().koukaon (8);
					}
				}
				if (ST.GetComponent<characterstatus>().MP>15)
				{
					if (Input.GetKeyDown (KeyCode.Alpha3)) {
						ST.GetComponent<characterstatus> ().MP -= 15;
						manager.kenup += 600;
						SE.GetComponent<SE> ().koukaon (8);
					}
				}
			}
		}
		
	}

	void OnMouseDown()
	{
		//入れ替えボタンを押したらアイテムとスキルを入れ替える
		if (manager.gameok == true) {
			_irekae = !_irekae;
		}
	}
}
