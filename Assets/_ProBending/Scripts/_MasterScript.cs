using UnityEngine;
using System.Collections;

public class _MasterScript : MonoBehaviour {

	private static readonly string TAG = "_MasterScript";

	MBP1MainMenu mainMenu;
	MBP1World world;

	SeTi_Base seasonOfTime = SeTiBigBang.Instance;
	
	void Start () {
		world = GameObject.Find("World").GetComponent<MBP1World>();
		world.TurnOff();
		
		mainMenu = GameObject.Find("Main Menu").GetComponent<MBP1MainMenu>();
		mainMenu.actionPlay += () => {
			UtilLogger.Log(TAG, "Play");
			world.TurnOn();
		};
		
		mainMenu.actionQuit += () => {
			UtilLogger.Log(TAG, "Quit");
			world.TurnOff();
		};

		seasonOfTime.Enter();
		UtilLogger.Log(TAG, seasonOfTime.GetType().Name + ": Enter");
	}
	
	void Update () {
		seasonOfTime.Update();

		if(seasonOfTime.IsFinished()) {
			seasonOfTime.Exit();
			UtilLogger.Log(TAG, seasonOfTime.GetType().Name + ": Exit");
			seasonOfTime = seasonOfTime.GetNextSeason();
			seasonOfTime.Enter();
			UtilLogger.Log(TAG, seasonOfTime.GetType().Name + ": Enter");
		}
	}
}
