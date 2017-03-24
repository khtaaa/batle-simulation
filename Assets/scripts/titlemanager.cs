using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlemanager : MonoBehaviour {
    
    //左クリックが押されたらbattleシーンに移動
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Application.LoadLevel("battle");
        }
	}
}
