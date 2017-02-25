using UnityEngine;
using System.Collections;

public class Laser6 : MonoBehaviour {

	public static bool canHit;

	// Use this for initialization
	void Start () {
		canHit = true;
	}

	// Update is called once per frame
	void Update () 
	{

	}

	public void HitOn()
	{
		canHit = true;
	}

	public void HitOff()
	{
		canHit = false;
	}
}
