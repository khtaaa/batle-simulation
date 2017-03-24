using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_hp : MonoBehaviour {
    characterstatus status;//ステータス
    public float HP;//HP
    public float MAXHP;//最大HP
    Slider _slider;//HPバー

    void Start()
    {
        //ステータス獲得
        status = transform.root.GetComponent<characterstatus>();
        //HPバー獲得
        _slider = GameObject.Find("enemy(HP)").GetComponent<Slider>();
        //敵ステータスのHP獲得
        HP = status.HP;
        //敵ステータスの最大HP獲得
        MAXHP = status.MAXHP;
    }

    void Update()
    {
        //敵ステータスのHP獲得
        HP = status.HP;
        //敵ステータスの最大HP獲得
        MAXHP = status.MAXHP;
        //HPバーに現在HP%を反映
        _slider.value = HP / MAXHP * 100;


    }
}
