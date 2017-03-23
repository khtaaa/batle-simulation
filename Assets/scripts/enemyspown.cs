using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspown : MonoBehaviour {
    public static int count;
    public static int spo;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
        count = 0;
        spo = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (spo < 1)
        {
            Instantiate(enemy, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
            count++;
        }
		
	}
}
