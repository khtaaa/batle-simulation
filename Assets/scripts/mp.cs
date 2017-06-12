using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mp : MonoBehaviour {
    characterstatus status;
    public float MP=100;//現在のMP
    public float MAXMP=100;//最大のMP
    Slider _slider;//シリンダー

    void Start()
    {
        status = GameObject.Find("player").GetComponent<characterstatus>();//プレイヤーのステータスを獲得
        _slider = GameObject.Find("Slider(MP)").GetComponent<Slider>();//シリンダー獲得
        MP = status.MP;//MP獲得
        MAXMP = status.MAXMP;//MAXMP獲得

    }
		
    void Update()
    {
        MP = status.MP;//MP獲得
        MAXMP = status.MAXMP;//MAXMP獲得
        _slider.value = MP / MAXMP * 100;//MPをシリンダーに反映


    }
}
