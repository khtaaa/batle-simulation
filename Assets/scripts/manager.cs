using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
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
	public GameObject bgm;
	void Start () {
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
		} else {
			gameok = true;
			menyuu.SetActive (false);
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
