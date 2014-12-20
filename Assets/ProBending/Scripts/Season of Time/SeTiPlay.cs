using UnityEngine;
using System.Collections;

public class SeTiPlay : SeTi_Base {

	MBP1World world;
	MBP1Controller controller;

	private SeTiPlay() {
		world = GuildOfMB.MBP1World;
		controller = GuildOfMB.MBP1Controller;
	}

	public override void Enter () {
		base.Enter ();

		world.TurnOn();
		controller.actionKeyDownEscape += () => {

		};
	}

	public override void Exit () {
		base.Exit ();

		world.TurnOff();
		controller.actionKeyDownEscape += () => {};
	}

	private static SeTiPlay instance;
	public static SeTiPlay Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiPlay();}
			
			return instance;
		}
	}
}
