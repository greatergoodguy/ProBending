using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class MBP1MainMenu : MBP1_Base {

	void Start() {
		{
			Button mbButtonPlay = transform.FindChild("Canvas").FindChild("Play Button").GetComponent<Button>();
			mbButtonPlay.onClick.AddListener(actionPlay.Invoke);
		}

		{
			Button mbButtonQuit = transform.FindChild("Canvas").FindChild("Quit Button").GetComponent<Button>();
			mbButtonQuit.onClick.AddListener(actionQuit.Invoke);
		}
	}

	public event Action actionPlay = () => {};
	public event Action actionQuit = () => {};

}
