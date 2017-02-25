using UnityEngine;
using System.Collections;

public class Reset_Game : MonoBehaviour {




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//-------------------------------------------- Debug Purposes ------------------------------------------
		//user presses the 1 key to restart level1.
		if (Input.GetKeyDown("1"))
		{
			Application.LoadLevel("scenes/level1");
		}

		//user presses the 2 key to restart level2.
		if (Input.GetKeyDown("2"))
		{
			Application.LoadLevel("scenes/level2");
		}
		//-------------------------------------------- Debug Purposes ------------------------------------------


		if (User_Interface.timer < 0) 
		{
			Player_Collision.reset = true;
			Reset ();
		} 
	
	}

	public static void Reset()
	{
		//reset timer
		User_Interface.timer = 300;

		//reset to level 1
		if (Player_Collision.level == 1) {
			Application.LoadLevel ("scenes/level1");
		} else if (Player_Collision.level == 2) { 
			Application.LoadLevel ("scenes/level2");
		} else if (Player_Collision.level == 3) {
			Application.LoadLevel ("scenes/level3");

		} else if (Player_Collision.level == 4) {
			Application.LoadLevel ("scenes/level4");

		} else if (Player_Collision.level == 5) {
			Application.LoadLevel ("scenes/level5");

		} else if (Player_Collision.level == 6) {
			Application.LoadLevel ("scenes/level6");

		} else if (Player_Collision.level == 7) {
			Application.LoadLevel ("scenes/level7");

		} else if (Player_Collision.level == 8) {
			Application.LoadLevel ("scenes/level8");

		} else if (Player_Collision.level == 9) {
			Application.LoadLevel ("scenes/level9");

		} else if (Player_Collision.level == 10) {
			Application.LoadLevel ("scenes/level10");
		} else {
			Application.LoadLevel ("scenes/Victory");
		}

	}
}
