﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mp : MonoBehaviour {
    public static float MP=100;
    public static float MAXMP=100;
    Slider _slider;
    void Start()
    {
        _slider = GameObject.Find("Slider(MP)").GetComponent<Slider>();


    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = MP / MAXMP * 100;


    }
}
