using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour {
    characterstatus status;
    public float HP=100;//現在のHP
    public float MAXHP=100;//最大HP
    Slider _slider;//シリンダー
	void Start () {
        status = GameObject.Find("player").GetComponent<characterstatus>();//pleysrのステータスを獲得
        _slider = GameObject.Find("Slider(HP)").GetComponent<Slider>();//シリンダー獲得
        HP = status.HP;//HP獲得
        MAXHP = status.MAXHP;//MAXHP獲得
	}
	
	// Update is called once per frame
	void Update () {
		HP = status.HP;//HP獲得
		MAXHP = status.MAXHP;//MAXHP獲得
        _slider.value = HP/MAXHP*100;//シリンダーにHP反映
	}
}
