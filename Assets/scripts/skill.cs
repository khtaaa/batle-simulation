using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour {
	public GameObject ST;
	public GameObject SE;

	// Use this for initialization
	void Start () {
		ST= GameObject.Find ("player");//player獲得
		SE = GameObject.Find ("SE");//効果音獲得

	}

	void Update () {

	}

	void OnMouseDown()
	{
		//ゲーム中なら
		if (manager.gameok == true) {
			//回復スキルをクリックしたら
			if (transform.tag == "kaihuku") {
				//MPが足りているならMPを消費してHPを回復
				if (ST.GetComponent<characterstatus> ().MP > 10 && ST.GetComponent<characterstatus> ().HP <= ST.GetComponent<characterstatus> ().MAXHP / 10 * 9) {
					ST.GetComponent<characterstatus> ().MP -= 10;
					ST.GetComponent<characterstatus> ().HP += ST.GetComponent<characterstatus> ().MAXHP / 10;
					SE.GetComponent<SE> ().koukaon (8);//効果音8番を再生
				}
			}

			//防御アップスキルをクリックしたら
			if (transform.tag == "tateup") {
				//MPが足りているならMPを消費して防御アップ
				if (ST.GetComponent<characterstatus> ().MP > 15) {
					ST.GetComponent<characterstatus> ().MP -= 15;
					manager.tateup += 600;
					SE.GetComponent<SE> ().koukaon (8);//効果音8番を再生
				}
			}

			//攻撃アップスキルをクリックしたら
			if (transform.tag == "kenup") {
				//MPが足りているならMPを消費して攻撃アップ
				if (ST.GetComponent<characterstatus> ().MP > 15) {
					ST.GetComponent<characterstatus> ().MP -= 15;
					manager.kenup += 600;
					SE.GetComponent<SE> ().koukaon (8);//効果音8番を再生
				}
			}
		}
	}
}
