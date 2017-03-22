using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp : MonoBehaviour {
    public static float HP=100;
    public static float MAXHP=100;
    Slider _slider;
	void Start () {
        _slider = GameObject.Find("Slider(HP)").GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        _slider.value = HP/MAXHP*100;
	}
}
