using UnityEngine;
using System.Collections;

public class BigBang : MonoBehaviour {

	MoBoMainMenu mainMenu;
	MoBoWorld world;

	void Start () {
		world = GameObject.Find("World").GetComponent<MoBoWorld>();
		world.TurnOff();

		mainMenu = GameObject.Find("Main Menu").GetComponent<MoBoMainMenu>();
		mainMenu.onPlayListener += () => {
			world.TurnOn();
		};

		mainMenu.onQuitListener += () => {
			world.TurnOff();
		};
	}

	void Update () {

	}
}
