using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour {

	private Text text;
	public static bool finish;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		text.color = new Color(0, 0, 0, 0);
		finish = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (finish) {
			text.color = new Color(0, 0, 0, 1);
			text.text = "You Won!";
			finish = false;
		}
	}
}
