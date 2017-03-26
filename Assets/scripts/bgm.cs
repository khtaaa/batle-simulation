using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour {
	public AudioClip[] bgmLists;
	AudioSource source;

	void Start () {
		source = GetComponent<AudioSource>();
		//source.PlayOneShot(bgmLists[0]);
		source.clip=bgmLists[0];
		source.Play();
	}

	void Update()
	{
	}
	
	public void bgmbgm(int i)
	{
		//source.Stop ();
		source.clip=bgmLists[i];
		source.Play();
		return;
	}

}
