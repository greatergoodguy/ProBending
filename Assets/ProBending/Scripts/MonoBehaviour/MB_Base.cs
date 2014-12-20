using UnityEngine;
using System.Collections;

public abstract class MB_Base : MonoBehaviour {

	void Start() {
		TurnOn();
	}

	public bool IsOn {
		get {
			return gameObject.activeInHierarchy;
		}
	}

	public void TurnOn() {
		gameObject.SetActive(true);
	}
	
	public void TurnOff() {
		gameObject.SetActive(false);
	}

	public void ToggleOnOff() {
		UtilLogger.Log("MB_Base", "ToggleOnOff()");
		if(IsOn) {
			UtilLogger.Log("MB_Base", "ToggleOnOff(): IsOn");
			TurnOff();
		}
		else {
			UtilLogger.Log("MB_Base", "ToggleOnOff(): IsOff");
			TurnOn();
		}
	}

}
