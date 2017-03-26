using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {

    public static bool gameok;//ゲーム開始されてるかされてないか
    public static bool gameov;//ゲームオーバーかそうでないか
    public static int coin=0;
	public static int wave = 0;
	int time=0;
	public GameObject wavetext;
	public static bool waveok = false;
	void Start () {
        gameok = true;//ゲーム開始
        gameov = false;//ゲームオーバーではないのでfalseにしておく
        coin = 0;
		wave = 1;
		time = 0;
		waveok = true;
		wavetext.SetActive (false);
	}

    void Update()
    {
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
            //左クリックでtitleに戻る
            if (Input.GetMouseButton(0))
            {
                Application.LoadLevel("title");
            }
        }
    }
}
