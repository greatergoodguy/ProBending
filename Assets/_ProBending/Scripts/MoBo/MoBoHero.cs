using UnityEngine;
using System.Collections;

public class MoBoHero : MoBo_Base {

	const string TAG = "MBHero";

	void Start () {

	}

	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Joystick1Button16)) {
			UtilLogger.Log(TAG, "A");
		}



	}
}
