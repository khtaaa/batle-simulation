using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public static int tateup;//防御アップ時間
	public static int kenup;//攻撃アップ時間
	public static bool menyu=false;//メニューが開いているか
    public static bool gameok;//ゲーム開始されてるかされてないか
    public static bool gameov;//ゲームオーバーかそうでないか
    public static int coin=0;//コイン所持数
	public static int wave = 0;//wave数
	int time=0;//waveテキスト表示する時間
	public GameObject wavetext;//waveテキスト
	public static bool waveok = false;//waveテキスト表示するかどうか
	public GameObject menyuu;//メニュー
	public GameObject status;//ステータステキスト
	public GameObject bgm;//BGM
	public GameObject ken;//攻撃アップアイコン
	public GameObject tate;//防御アップアイコン

	void Start () {
		tateup = 0;
		kenup = 0;
        gameok = true;//ゲーム開始
        gameov = false;//ゲームオーバーではないのでfalseにしておく
        coin = 0;
		wave = 1;
		time = 0;
		waveok = true;
		wavetext.SetActive (false);
		menyu = false;
		bgm = GameObject.Find("BGM");//BGMのオブジェクト代入
		bgm.GetComponent<bgm>().bgmbgm(0);//BGM0番を再生
	}

    void Update()
    {
		//ゲーム中
		if (gameok == true) {
			//防御アップ中なら
			if (tateup > 0) {
				tate.SetActive (true);//防御アップアイコン表示
				tateup--;
			}

			//攻撃アップ中なら
			if (kenup > 0) {
				ken.SetActive (true);//攻撃アップアイコンを表示
				kenup--;
			}

			//防御アップ中じゃないなら
			if (tateup <= 0) {
				tate.SetActive (false);//防御アップアイコン非表示
				tateup = 0;
			}

			//攻撃アップ中じゃないなら
			if (kenup <= 0) {
				ken.SetActive (false);//攻撃アップアイコンを非表示
				kenup = 0;
			}
		}

		//waveの最高記録更新
		if (scoartext.scoar < wave) {
			scoartext.scoar = wave;
		}
		//メニュー
		if (menyu == true) {
			gameok = false;
			menyuu.SetActive (true);
			status.SetActive (true);
		} else {
			gameok = true;
			menyuu.SetActive (false);
			status.SetActive (false);
		}

		//wave
		if (waveok == true) {
			wavetext.SetActive (true);
			time++;
			if (time == 120) {
				time = 0;
				waveok = false;
			}
		} else {
			wavetext.SetActive (false);
		}


        //ゲームオーバーになったら動作
        if (gameov == true)
        {
			gameok = false;
            //左クリックでtitleに戻る
            if (Input.GetMouseButton(0))
            {
                Application.LoadLevel("title");
            }
        }
    }
}
