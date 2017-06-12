using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour {
	public AudioClip[] bgmLists;//BGMリスト
	AudioSource source;//AudioSource

	public void bgmbgm(int i)
	{
		source = GetComponent<AudioSource>();//AudioSource獲得
		source.Stop ();//BGNストップ
		source.clip=bgmLists[i];//clipにBGMを代入
		source.Play();//BGN再生
		return;
	}

}
