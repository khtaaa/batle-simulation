using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mp : MonoBehaviour {
    characterstatus status;
    public float MP=100;
    public float MAXMP=100;
    Slider _slider;
    void Start()
    {
        status = GameObject.Find("player").GetComponent<characterstatus>();
        _slider = GameObject.Find("Slider(MP)").GetComponent<Slider>();
        MP = status.MP;
        MAXMP = status.MAXMP;

    }

    // Update is called once per frame
    void Update()
    {
        MP = status.MP;
        MAXMP = status.MAXMP;
        _slider.value = MP / MAXMP * 100;


    }
}
