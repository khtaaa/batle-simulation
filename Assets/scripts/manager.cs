using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
    public static bool gameok;//ゲーム開始されてるかされてないか
    public static bool gameov;//ゲームオーバーかそうでないか

	void Start () {
        gameok = true;//ゲーム開始
        gameov = false;//ゲームオーバーではないのでfalseにしておく
	}

    void Update()
    {

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
