using UnityEngine;
using System.Collections;

public class SeTiBigBang : SeTi_Base {

	private SeTiBigBang() {}

	public override void Enter () {
		base.Enter ();

		MBP1MainMenu mainMenu = GuildOfMB.MBP1MainMenu;
		mainMenu.TurnOff();

		MBP1World world = GuildOfMB.MBP1World;
		world.TurnOff();
	}

	public override bool IsFinished () {
		return true;
	}

	public override SeTi_Base GetNextSeason () {
		return SeTiMainMenu.Instance;
	}

	private static SeTiBigBang instance;
	public static SeTiBigBang Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiBigBang();}
			
			return instance;
		}
	}
}
