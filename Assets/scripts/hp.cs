using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour {
    characterstatus status;
    public float HP=100;
    public float MAXHP=100;
    Slider _slider;
	void Start () {
        status = GameObject.Find("player").GetComponent<characterstatus>();
        _slider = GameObject.Find("Slider(HP)").GetComponent<Slider>();
        HP = status.HP;
        MAXHP = status.MAXHP;
	}
	
	// Update is called once per frame
	void Update () {
        HP = status.HP;
        MAXHP = status.MAXHP;
        _slider.value = HP/MAXHP*100;
	}
}
