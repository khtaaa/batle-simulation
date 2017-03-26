using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botan_sc : MonoBehaviour {
    public GameObject SE;//音源

    //このオブジェクトがクリックされたら動作
    void OnMouseDown()
    {
        //ゲーム状態を切り替え
		manager.menyu = !manager.menyu;
        //スクロール状態を切り替え
        haikei.move = !haikei.move;
        //効果音
        SE.GetComponent<SE>().koukaon(0);
    }
}
