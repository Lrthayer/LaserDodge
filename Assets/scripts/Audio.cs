using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {

	public static int LeftOff = 0;

	// Use this for initialization
	void Start () 
	{
		this.GetComponent<AudioSource> ().timeSamples = LeftOff;
		//Debug.Log ("leftoff: " + (LeftOff);
		//Debug.Log ("timesample: " + this.GetComponent<AudioSource> ().timeSamples);
		this.GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Player_Collision.reset)
		{
			LeftOff = this.GetComponent<AudioSource>().timeSamples;
			Player_Collision.reset = false;
		}
	}
}
