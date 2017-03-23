using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_hp : MonoBehaviour {
    characterstatus status;
    public float hpp;
    public float maxhpp;
    Slider _slider;
    // Use this for initialization
    void Start()
    {
        status = transform.root.GetComponent<characterstatus>();
        _slider = GameObject.Find("enemy(HP)").GetComponent<Slider>();
        hpp = status.HP;
        maxhpp = status.MAXHP;
    }

    // Update is called once per frame
    void Update()
    {
        hpp = status.HP;
        maxhpp = status.MAXHP;
        _slider.value = hpp / maxhpp * 100;


    }
}
