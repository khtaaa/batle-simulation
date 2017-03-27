using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour {
	public AudioClip[] bgmLists;
	AudioSource source;

	public void bgmbgm(int i)
	{
		source = GetComponent<AudioSource>();
		source.Stop ();
		source.clip=bgmLists[i];
		source.Play();
		return;
	}

}
