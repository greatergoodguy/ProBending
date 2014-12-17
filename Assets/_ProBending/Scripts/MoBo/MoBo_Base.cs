using UnityEngine;
using System.Collections;

public abstract class MoBo_Base : MonoBehaviour {

	public void TurnOn() {
		gameObject.SetActive(true);
	}
	
	public void TurnOff() {
		gameObject.SetActive(false);
	}

}
