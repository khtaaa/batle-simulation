using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class status_text : MonoBehaviour {
	public GameObject pl;

	// Use this for initialization
	void Start () {
		pl= GameObject.Find ("player");
		this.GetComponent<Text>().text = "ステータス\n 攻撃力:"+pl.GetComponent<characterstatus>().power+"\n 防御力:"+pl.GetComponent<characterstatus>().defense + "\n 攻撃速度:"
			+pl.GetComponent<characterstatus>().attackspeed + "\n HP/MAXHP:"+pl.GetComponent<characterstatus>().HP+"/"+pl.GetComponent<characterstatus>().MAXHP
			+"\n MP/MAXMP:"+pl.GetComponent<characterstatus>().MP+"/"+pl.GetComponent<characterstatus>().MAXMP;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Text>().text = "ステータス\n 攻撃力:"+pl.GetComponent<characterstatus>().power+"\n 防御力:"+pl.GetComponent<characterstatus>().defense + "\n 攻撃速度:"
			+pl.GetComponent<characterstatus>().attackspeed + "\n HP/MAXHP:"+pl.GetComponent<characterstatus>().HP+"/"+pl.GetComponent<characterstatus>().MAXHP
			+"\n MP/MAXMP:"+pl.GetComponent<characterstatus>().MP+"/"+pl.GetComponent<characterstatus>().MAXMP;
	}
}
