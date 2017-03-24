using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_botan : MonoBehaviour {
    public bool coinok = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (manager.coin > 0)
        {
            coinok = true;
        }
        else
        {
            coinok = false;
        }
	}

    void OnMouseDown()
    {
        if (gameObject.CompareTag("hp"))
        {
            enemyspown.aitemu = 0;
            enemyspown.coin = true;
        }

        if (gameObject.CompareTag("ken"))
        {
            enemyspown.aitemu = 1;
            enemyspown.coin = true;
        }

        if (gameObject.CompareTag("mp"))
        {
            enemyspown.aitemu = 2;
            enemyspown.coin = true;
        }

        if (gameObject.CompareTag("tate"))
        {
            enemyspown.aitemu = 3;
            enemyspown.coin = true;
        }
    }
}
