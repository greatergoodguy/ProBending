using UnityEngine;
using System.Collections;

public abstract class MB_Base : MonoBehaviour {

	public void TurnOn() {
		gameObject.SetActive(true);
	}
	
	public void TurnOff() {
		gameObject.SetActive(false);
	}

}
