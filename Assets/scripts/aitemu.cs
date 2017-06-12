using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aitemu : MonoBehaviour {

    void OnMouseDown()
    {
		//コインが0以上でゲーム中ならアイテム生成
		if (manager.coin > 0 && manager.gameok==true)
        {
			//クリックした画像のタグを判定してアイテムを生成
            if (transform.tag=="hp")
            {
                manager.coin--;//コイン消費
                spown.aitemu = 0;//アイテム番号入力
                spown.coin = true;//アイテム生成
            }

            if (transform.tag == "ken")
            {
                manager.coin--;
                spown.aitemu = 1;
                spown.coin = true;
            }

            if (transform.tag == "mp")
            {
                manager.coin--;
                spown.aitemu = 2;
                spown.coin = true;
            }

            if (transform.tag == "tate")
            {
                manager.coin--;
                spown.aitemu = 3;
                spown.coin = true;
            }

			if (transform.tag == "kurisutaru")
			{
				manager.coin--;
				spown.aitemu = 4;
				spown.coin = true;
			}
        }
    }
}
