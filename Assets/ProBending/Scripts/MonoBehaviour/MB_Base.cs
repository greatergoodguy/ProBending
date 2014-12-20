using UnityEngine;
using System.Collections;

public abstract class MB_Base : MonoBehaviour {

	public bool IsOn {
		get {
			return gameObject.activeSelf;
		}
	}

	public void TurnOn() {
		gameObject.SetActive(true);
	}
	
	public void TurnOff() {
		gameObject.SetActive(false);
	}

	public void ToggleOnOff() {
		if(IsOn) {
			TurnOff();
		}
		else {
			TurnOn();
		}
	}

}
