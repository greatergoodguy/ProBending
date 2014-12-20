using UnityEngine;
using System;
using System.Collections;

public class MBP1Controller : MBP1_Base {

	void Update() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			actionKeyDownEscape();
		}
	
	}

	public event Action actionKeyDownEscape = () => {};

}
