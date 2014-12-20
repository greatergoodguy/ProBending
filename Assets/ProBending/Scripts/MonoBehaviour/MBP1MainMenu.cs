using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class MBP1MainMenu : MBP1_Base {

	Button mbButtonPlay;
	Button mbButtonQuit;

	Action actionActive = () => {};

	void Start() {

		transform.FindChild("Canvas").gameObject.SetActive(true);

		mbButtonPlay = transform.FindChild("Canvas").FindChild("Play Button").GetComponent<Button>();
		mbButtonPlay.onClick.AddListener(actionPlay.Invoke);

		mbButtonQuit = transform.FindChild("Canvas").FindChild("Quit Button").GetComponent<Button>();
		mbButtonQuit.onClick.AddListener(actionQuit.Invoke);
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			mbButtonPlay.Select();
			actionActive = actionPlay;
		}

		if(Input.GetKeyDown(KeyCode.DownArrow)) {
			mbButtonQuit.Select();
			actionActive = actionQuit;
		}

		if(Input.GetKeyDown(KeyCode.KeypadEnter)) {
			actionActive();
		}
	}

	public event Action actionPlay = () => {};
	public event Action actionQuit = () => {};

}
