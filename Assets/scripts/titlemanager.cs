using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlemanager : MonoBehaviour {
    public GameObject SE;//音源
    float time;
    bool ok;
    void Start()
    {
        //初期化
        time = 0;
        ok = false;
    }
    //左クリックが押されたら効果音が鳴り3秒後にbattleシーンに移動
	void Update () {
        if (Input.GetMouseButton(0))
        {
            SE.GetComponent<SE>().koukaon(2);
            ok = true;
        }
        if (ok == true)
        {
            time += Time.deltaTime;
            if (time > 1.5f)
            {
                Application.LoadLevel("battle");
            }
        }
	}
}
