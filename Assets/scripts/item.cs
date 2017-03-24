using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {
    void Update()
    {
        //ゲーム開始状態なら左に移動する
        if (manager.gameok == true)
        {
            transform.Translate(-0.06f, 0, 0);
        }
    }

    //触れたオブジェクトがプレイヤーならアイテム消滅
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
