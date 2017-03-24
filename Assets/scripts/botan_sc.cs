using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botan_sc : MonoBehaviour {

    //このオブジェクトがクリックされたら動作
    void OnMouseDown()
    {
        //ゲーム状態を切り替え
        manager.gameok = !manager.gameok;
        //スクロール状態を切り替え
        haikei.move = !haikei.move;
    }
}
