using UnityEngine;
using System;
using System.Collections;

public class MBP1Controller : MBP1_Base {

	private static readonly string TAG = "MBP1Controller";

	void Start() {
		UtilLogger.Log(TAG, "Start()");
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			actionKeyDownEscape();
		}
	
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			UtilLogger.Log(TAG, "Update() - GetKeyDown(UpArrow)");
		}

	}

	public event Action actionKeyDownEscape = () => {};

}
