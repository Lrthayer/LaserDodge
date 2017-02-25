using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class User_Interface : MonoBehaviour {

	public Text timerUI;
	public static int timer = 300;
	public int level_Timer = 0;

	// Use this for initialization
	void Start () 
	{
		if (level_Timer != 0) 
		{
			timer = level_Timer;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{	
		timer -= 1;
		timerUI.text = "Timer:  " + timer; 
	}
}
