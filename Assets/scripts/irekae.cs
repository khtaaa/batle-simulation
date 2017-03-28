using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irekae : MonoBehaviour {
	public bool _irekae;
	public GameObject[] item;
	public GameObject[] skill;
	public GameObject ST;
	public GameObject SE;
	// Use this for initialization
	void Start () {
		_irekae = true;
		ST= GameObject.Find ("player");
		SE = GameObject.Find ("SE");
	}
	
	// Update is called once per frame
	void Update () {
		if (manager.gameok == true) {
			if (Input.GetKeyDown (KeyCode.Backspace)) {
				_irekae = !_irekae;
			}
			if (_irekae == true) {
				for (int i = 0; i < item.Length; i++) {
					item [i].SetActive (true);
				}
				for (int i = 0; i < skill.Length; i++) {
					skill [i].SetActive (false);
				}

				if (manager.coin > 0) {
					if (Input.GetKeyDown (KeyCode.Alpha1)) {
						manager.coin--;
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
				for (int i = 0; i < item.Length; i++) {
					item [i].SetActive (false);
				}
				for (int i = 0; i < skill.Length; i++) {
					skill [i].SetActive (true);
				}

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
