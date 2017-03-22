using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterstatus : MonoBehaviour {
    //体力
    public int HP = 100;
    public int MAXHP = 100;
    //魔力
    public int MP = 100;
    public int MAXMP = 100;
    //攻撃力
    public int power = 5;
    //移動速度
    public float speed = 0.05f;
    //攻撃対象
    public GameObject target = null;
}
