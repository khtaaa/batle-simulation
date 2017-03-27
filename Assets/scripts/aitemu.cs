using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aitemu : MonoBehaviour {

    void OnMouseDown()
    {
		if (manager.coin > 0)
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

			if (transform.tag == "kurisutaru")
			{
				manager.coin--;
				enemyspown.aitemu = 4;
				enemyspown.coin = true;
			}
        }
    }
}
