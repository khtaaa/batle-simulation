using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour {
    public AudioClip[] seLists;
    AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
		
	}

    public void koukaon(int i)
    {
        source.PlayOneShot(seLists[i]);
    }
}
