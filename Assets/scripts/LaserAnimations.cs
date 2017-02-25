using UnityEngine;
using System.Collections;

public class LaserAnimations : MonoBehaviour {

	GameObject laser1;
	GameObject laser2;


	// Use this for initialization
	void Start () 
	{
		
		laser1 = GameObject.Find ("timer_laser_0");	
		laser2 = GameObject.Find ("timer_laser_1");	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void TurnOn()
	{
		
		laser1.GetComponent<Animator> ().SetBool ("LaserOn", true);
		laser2.GetComponent<Animator> ().SetBool ("LaserOn", true);
	}

	public void TurnOff()
	{

		laser1.GetComponent<Animator> ().SetBool ("LaserOn", false);
		laser2.GetComponent<Animator> ().SetBool ("LaserOn", false);
	}
}
