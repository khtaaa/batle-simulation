using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status_text : MonoBehaviour {
	public GameObject pl;
	characterstatus ST;

	// Use this for initialization
	void Start () {
		pl= GameObject.Find ("player");//player獲得
		ST=pl.GetComponent<characterstatus>();//playerのステータスを獲得

		this.GetComponent<Text>().text = "ステータス\n 攻撃力:"+ST.power+"\n 防御力:"+ST.defense + "\n 攻撃速度:"
			+ST.attackspeed + "\n HP/MAXHP:"+ST.HP+"/"+ST.MAXHP
			+"\n MP/MAXMP:"+ST.MP+"/"+ST.MAXMP;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "ステータス\n 攻撃力:"+ST.power+"\n 防御力:"+ST.defense + "\n 攻撃速度:"
			+ST.attackspeed + "\n HP/MAXHP:"+ST.HP+"/"+ST.MAXHP
			+"\n MP/MAXMP:"+ST.MP+"/"+ST.MAXMP;
	}
}
