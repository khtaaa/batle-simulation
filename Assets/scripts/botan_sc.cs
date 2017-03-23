using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botan_sc : MonoBehaviour {

    void OnMouseDown()
    {
        if (manager.gameok == true)
        {
            manager.gameok = false;
        }

        if (manager.gameok == false)
        {
            manager.gameok = true;
        }
    }
}
