using UnityEngine;
using System.Collections;

public class SeTiMainMenu : SeTi_Base {
	
	private static SeTiMainMenu instance;
	private SeTiMainMenu() {}
	public static SeTiMainMenu Instance {
		get 
		{
			if (instance == null) {
				instance = new SeTiMainMenu();}
			
			return instance;
		}
	}
}