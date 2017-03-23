using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {
    public static bool gameok;
    public static bool gameov;

	// Use this for initialization
	void Start () {
        gameok = true;
        gameov = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameov == true)
        {
            if (Input.GetMouseButton(0))
            {
                Application.LoadLevel("title");
            }
        }
		
	}
}
