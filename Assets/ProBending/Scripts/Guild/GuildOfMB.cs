using UnityEngine;
using System.Collections;

public class GuildOfMB {

	private static MBP1MainMenu mbp1MainMenu;
	public static MBP1MainMenu MBP1MainMenu {
		get  { 
			if(mbp1MainMenu == null) {
				mbp1MainMenu = GameObject.Find("Main Menu").GetComponent<MBP1MainMenu>();
			} 
			return mbp1MainMenu;
		}
	}

	private static MBP1World mbp1World;
	public static MBP1World MBP1World {
		get  { 
			if(mbp1World == null) {
				mbp1World = GameObject.Find("World").GetComponent<MBP1World>();
			} 
			return mbp1World;
		}
	}

	private static MBP1Controller mbp1Controller;
	public static MBP1Controller MBP1Controller {
		get  { 
			if(mbp1Controller == null) {
				mbp1Controller = GameObject.Find("Controller").GetComponent<MBP1Controller>();
			} 
			return mbp1Controller;
		}
	}
}
