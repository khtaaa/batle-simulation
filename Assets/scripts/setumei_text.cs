using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setumei_text : MonoBehaviour {
	public static int setumei = 0;
	public GameObject player;//player
	public GameObject enemy;//enemy
	public GameObject kougeki;//攻撃
	public GameObject koin;//コイン
	public GameObject botan;//一時停止
	public GameObject[] skill;//スキルリスト
	public GameObject[] item;//アイテムリスト
	public GameObject irekae;//入れ替え
	public GameObject HP;//HPゲージ
	public GameObject MP;//MPゲージ
	public GameObject SE;//音源
	public int rand;//乱数
	public GameObject bgm;

	void Start () {
		//初期化
		setumei = 0;
		this.GetComponent<Text>().text = "チュートリアル" ;
		irekae.SetActive (false);
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

	void Update () {

		if (setumei == 0) {
			this.GetComponent<Text> ().text = "チュートリアル";
			HP.SetActive (false);
			MP.SetActive (false);
		}
		if (setumei == 1) {
			this.GetComponent<Text> ().text = "画面左上の緑のゲージがHPゲージで\nピンクのゲージがMPゲージです";
			HP.SetActive (true);
			MP.SetActive (true);
			manager.gameok = false;
			player.SetActive (false);
			enemy.SetActive (false);
		}
		if(setumei==2)
		{
			this.GetComponent<Text> ().text = "画面クリック(スペース)で攻撃します";
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
				Instantiate (kougeki, enemy.transform.position + new Vector3 (Random.Range (-0.5f, 1f), Random.Range (-0.5f, 1f), -0.1f), Quaternion.identity);
				rand = Random.Range(3, 8);
				SE.GetComponent<SE>().koukaon(rand);
			}
			manager.gameok = true;
			player.SetActive (true);
			enemy.SetActive (true);
			koin.SetActive (false);
		}

		if (setumei == 3) {
			this.GetComponent<Text> ().text = "敵を倒すとランダムでコインが手に入ります";
			enemy.SetActive (false);
			koin.SetActive (true);
			for (int i = 0; i < item.Length; i++) {
				item [i].SetActive (false);
			}
			irekae.SetActive (false);
		}
		if (setumei == 4) {
			this.GetComponent<Text> ().text = "画面下にあるのはアイテムです\nクリックするとコインを消費してキャラクターを強化できます\nキーボードの1、2、3、4、で使用でき\n左から順にHP回復、MP回復、防御力増加、攻撃力増加、攻撃速度増加です";
			for (int i = 0; i < item.Length; i++) {
				item [i].SetActive (true);
			}
			for (int i = 0; i < skill.Length ; i++) {
				skill [i].SetActive (false);
			}
			irekae.SetActive (true);
			koin.SetActive (false);
		}

		if (setumei == 5) {
			this.GetComponent<Text> ().text = "アイテム欄の右側のボタン(左ALT)を押すと\nアイテムとスキルが入れ替わります";

			for (int i = 0; i < item.Length; i++) {
				item [i].SetActive (false);
			}
			for (int i = 0; i < skill.Length ; i++) {
				skill [i].SetActive (true);
			}
		}

		if (setumei == 6) {
			this.GetComponent<Text> ().text = "MPを消費してスキルが発動できます\nキーボードの1、2、3、で使用でき\n左からHP回復、一定時間防御増加\n一定時間攻撃増加です";
			for (int i = 0; i < skill.Length ; i++) {
				skill [i].SetActive (true);
			}
			irekae.SetActive (true);
			player.SetActive (true);
		}

		if (setumei == 7) {
			this.GetComponent<Text> ().text = "HPがなくなってしまうとゲームオーバーになってしまいます";
			for (int i = 0; i < skill.Length ; i++) {
				skill [i].SetActive (false);
			}
			irekae.SetActive (false);
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
			botan.SetActive (false);
		}

		if (setumei == 11) {
			this.GetComponent<Text> ().text = "最後に右上のボタン(T)を押すと一時停止できます";
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
