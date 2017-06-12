using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class SE : MonoBehaviour {
    public AudioClip[] seLists;//効果音リスト
	AudioSource source;//AudioSource

		void Start () {
		source = GetComponent<AudioSource>();//AudioSource獲得
	}

    public void koukaon(int i)
    {
		source.PlayOneShot (null);//効果音初期化
        source.PlayOneShot(seLists[i]);//効果音再生
		return;
    }
}
