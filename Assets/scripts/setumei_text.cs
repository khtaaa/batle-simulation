using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setumei_text : MonoBehaviour {
	public static int setumei = 0;
	public GameObject player;
	public GameObject enemy;
	public GameObject kougeki;
	public GameObject koin;
	public GameObject botan;
	public GameObject[] skill;
	public GameObject[] item;
	public GameObject HP;
	public GameObject MP;
	public GameObject SE;//音源
	public int rand;//乱数
	public GameObject bgm;

	// Use this for initialization
	void Start () {
		setumei = 0;
		this.GetComponent<Text>().text = "チュートリアル" ;
		botan.SetActive (false);
		player.SetActive (false);
		enemy.SetActive (false);
		koin.SetActive (false);
		HP.SetActive (false);
		MP.SetActive (false);
		bgm.GetComponent<bgm>().bgmbgm(2);
		for (int i = 0; i < item.Length; i++) {
			item [i].SetActive (false);
		}
		for (int i = 0; i < skill.Length; i++) {
			skill [i].SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (setumei == 0) {
			this.GetComponent<Text> ().text = "チュートリアル";
		}
		if (setumei == 1) {
			this.GetComponent<Text> ().text = "画面クリック(スペース)で攻撃します";
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				Instantiate (kougeki, enemy.transform.position + new Vector3 (Random.Range (-0.5f, 1f), Random.Range (-0.5f, 1f), -0.1f), Quaternion.identity);
				rand = Random.Range(3, 8);
				SE.GetComponent<SE>().koukaon(rand);
			}
			manager.gameok = true;
			player.SetActive (true);
			enemy.SetActive (true);
		}

		if (setumei == 2) {
			this.GetComponent<Text> ().text = "画面下にあるのはアイテムです\nクリックするとコインを消費して\nキャラクターを強化できます\n左から順にHP回復、MP回復、防御力増加、攻撃力増加、攻撃速度増加です";
			for (int i = 0; i < item.Length; i++) {
				item [i].SetActive (true);
			}

		}
		if (setumei == 3) {
			this.GetComponent<Text> ().text = "コインは敵を倒すとランダムで手に入ります";
			enemy.SetActive (false);
			koin.SetActive (true);
		}

		if (setumei == 4) {
			this.GetComponent<Text> ().text = "アイテム欄の右側のボタン(backspace)を押すと\nアイテムとスキルが入れ替わります";
			koin.SetActive (false);
			for (int i = 1; i < item.Length - 1; i++) {
				item [i].SetActive (false);
			}
			for (int i = 0; i < skill.Length ; i++) {
				skill [i].SetActive (true);
			}
		}

		if (setumei == 5) {
			this.GetComponent<Text> ().text = "MPを消費してスキルが発動できます\n左からHP回復、一定時間防御増加\n一定時間攻撃増加です";
		}

		if (setumei == 6) {
			this.GetComponent<Text> ().text = "左上の緑のゲージがHPゲージで\nピンクのゲージがMPゲージです";
			for (int i = 0; i < skill.Length ; i++) {
				skill [i].SetActive (false);
			}
			item [0].SetActive (false);
			item [item.Length - 1].SetActive (false);
			HP.SetActive (true);
			MP.SetActive (true);
		}

		if (setumei == 7) {
			this.GetComponent<Text> ().text = "HPがなくなってしまうとゲームオーバーになってしまいます";
			player.SetActive (false);
		}

		if (setumei == 8) {
			this.GetComponent<Text> ().text = "1waveは雑魚敵が9体出てきて最後にボスが出てきます";
			HP.SetActive (false);
			MP.SetActive (false);
		}

		if (setumei == 9) {
			this.GetComponent<Text> ().text = "ボスを倒すとそのwaveはクリアになります";
		}
		if (setumei == 10) {
			this.GetComponent<Text> ().text = "waveが上がっていくごとに敵が強くなっていきますが\n10waveごとにキャラクターの最大HPとMPも増加します";
		}

		if (setumei == 11) {
			this.GetComponent<Text> ().text = "最後に右上のボタンを押すと一時停止できます";
			botan.SetActive (true);
		}

		if (setumei == 12) {
			this.GetComponent<Text> ().text = "それではがんばってください！";
			botan.SetActive (false);
		}

		if (setumei == 13) {
			Application.LoadLevel("battle");
		}
		
	}
}
