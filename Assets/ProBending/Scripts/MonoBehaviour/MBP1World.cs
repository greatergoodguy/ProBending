using UnityEngine;
using System.Collections;

public class MBP1World : MBP1_Base {

	MBP2Menu mbp2Menu;

	void Start () {
		transform.FindChild("Continent").gameObject.SetActive(true);

		mbp2Menu = transform.FindChild("Continent").FindChild("Menu").gameObject.GetComponent<MBP2Menu>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			mbp2Menu.ToggleOnOff();
		}
	}

}
