using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikei : MonoBehaviour {
    public static bool move=true;//スクロール状態
	void Update () {

        //スクロール可能状態なら背景をスクロール
        if (move==true)
        {
            transform.Translate(-0.05f, 0, 0);
        }

        //左端に行ったら右に戻る
		if (transform.position.x < -18.5f ) {
			transform.position = new Vector3 (18.5f, 0, 1);
		}
	}
}
