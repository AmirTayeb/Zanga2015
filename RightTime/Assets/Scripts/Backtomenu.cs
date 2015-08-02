using UnityEngine;
using System.Collections;

public class Backtomenu : MonoBehaviour {

	public void BackToMainMenu()
	{
		Application.LoadLevel(0);
	}
	
	public void ExitGame()
	{
		Application.Quit();
	}
}
