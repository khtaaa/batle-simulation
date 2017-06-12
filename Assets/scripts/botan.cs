using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botan : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void tugi()
	{
		//次の説明
		setumei_text.setumei++;
	}

	public void mae()
	{
		//前の説明
		setumei_text.setumei--;
		//0以下にならないように調節
		if (setumei_text.setumei < 0) {
			setumei_text.setumei = 0;
		}
	}

	public void sukippu()
	{
		//バトルシーンに切り替え
		Application.LoadLevel("battle");
	}
}
