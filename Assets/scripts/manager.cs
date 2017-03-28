using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
	public static int tateup;
	public static int kenup;
	public static bool menyu=false;
    public static bool gameok;//ゲーム開始されてるかされてないか
    public static bool gameov;//ゲームオーバーかそうでないか
    public static int coin=0;
	public static int wave = 0;
	int time=0;
	public GameObject wavetext;
	public bool mugen = false;
	public static bool waveok = false;
	public GameObject menyuu;
	public GameObject status;
	public GameObject bgm;
	public GameObject ken;
	public GameObject tate;

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
		bgm = GameObject.Find("BGM");
		bgm.GetComponent<bgm>().bgmbgm(0);
	}

    void Update()
    {
		if (gameok == true) {
			if (tateup > 0) {
				tate.SetActive (true);
				tateup--;
			}
			if (kenup > 0) {
				ken.SetActive (true);
				kenup--;
			}

			if (tateup <= 0) {
				tate.SetActive (false);
				tateup = 0;
			}
			if (kenup <= 0) {
				ken.SetActive (false);
				kenup = 0;
			}
		}
		scoartext.scoar = wave;
		if (mugen == true) {
			if (coin < 1) {
				coin = 1;
			}
		}
		if (menyu == true) {
			if ((Input.GetKey (KeyCode.LeftControl)) && (Input.GetKey (KeyCode.C))) {
				if (Input.GetKeyDown (KeyCode.Space)) {
					mugen = !mugen;
				}
			}
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
