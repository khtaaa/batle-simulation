using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_hp : MonoBehaviour {
    Slider _slider;
    float maxhpp;
    float hpp = 100;
    // Use this for initialization
    void Start()
    {
        _slider = GameObject.Find("enemy(HP)").GetComponent<Slider>();
        maxhpp = enemy.enemy_maxhp;


    }

    // Update is called once per frame
    void Update()
    {
        hpp = enemy.enemy_hp;
        _slider.value = hpp / maxhpp * 100;


    }
}
