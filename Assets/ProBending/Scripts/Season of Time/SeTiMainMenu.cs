using UnityEngine;
using System.Collections;

public class SeTiMainMenu : SeTi_Base {

	bool isFinished;

	MBP1MainMenu mainMenu;

	private SeTiMainMenu() {
		mainMenu = GuildOfMB.MBP1MainMenu;
		mainMenu.TurnOn();
	}

	public override void Enter () {
		base.Enter ();

		isFinished = false;

		mainMenu.actionPlay += () => {
			isFinished = true;
		};
		
		mainMenu.actionQuit += () => {
			Application.Quit();
		};
	}

	public override void Exit () {
		base.Exit ();

		mainMenu.actionPlay += () => {};
		mainMenu.actionQuit += () => {};
		mainMenu.TurnOff();
	}

	public override bool IsFinished () {
		return isFinished;
	}

	public override SeTi_Base GetNextSeason () {
		return SeTiPlay.Instance;
	}

	private static SeTiMainMenu instance;
	public static SeTiMainMenu Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiMainMenu();}
			
			return instance;
		}
	}
}