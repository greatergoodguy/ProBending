using UnityEngine;
using System.Collections;

public class MBP1MainMenu : MBP1_Base {

	public delegate void OnPlayListener();
	public event OnPlayListener onPlayListener = () => {};
	public void OnPlay() {
		onPlayListener();
	}

	public delegate void OnQuitListener();
	public event OnQuitListener onQuitListener = () => {};
	public void OnQuit() {
		onQuitListener();
	}

}
