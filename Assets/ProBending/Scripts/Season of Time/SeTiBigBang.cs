using UnityEngine;
using System.Collections;

public class SeTiBigBang : SeTi_Base {

	public override bool IsFinished () {
		return true;
	}

	public override SeTi_Base GetNextSeason () {
		return SeTiMainMenu.Instance;
	}

	private static SeTiBigBang instance;
	private SeTiBigBang() {}
	public static SeTiBigBang Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiBigBang();}
			
			return instance;
		}
	}
}
