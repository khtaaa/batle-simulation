using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aitemu : MonoBehaviour {
    public bool coinok = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        if (coinok == true)
        {
            if (transform.tag=="hp")
            {
                manager.coin--;
                enemyspown.aitemu = 0;
                enemyspown.coin = true;
            }

            if (transform.tag == "ken")
            {
                manager.coin--;
                enemyspown.aitemu = 1;
                enemyspown.coin = true;
            }

            if (transform.tag == "mp")
            {
                manager.coin--;
                enemyspown.aitemu = 2;
                enemyspown.coin = true;
            }

            if (transform.tag == "tate")
            {
                manager.coin--;
                enemyspown.aitemu = 3;
                enemyspown.coin = true;
            }
        }
    }
}
