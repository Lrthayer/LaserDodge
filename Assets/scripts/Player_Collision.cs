using UnityEngine;
using System.Collections;

public class Player_Collision : MonoBehaviour {

	public static int level = 1;
	private GameObject laserDoor;
	private GameObject lever;
	public static bool reset;


	// Use this for initialization
	void Start () 
	{
		laserDoor = GameObject.Find ("laserDoor");
		lever = GameObject.Find ("knob");

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	//used to check collision if object has no trigger on
	void OnCollisionEnter2D(Collision2D otherCollision)
	{
		//the player collides with the laser object
		if (otherCollision.gameObject.tag == "laser") 
		{	
			reset = true;

			//destroy the player object.
			Destroy (this.gameObject);

			//reset the level
			Reset_Game.Reset ();
		}

	
	}


	void OnTriggerStay2D(Collider2D other) {
		//the player collides with the laser object
		if (other.gameObject.tag == "specialLaser") 
		{
			if (Laser6.canHit)
			{
				reset = true;

				//destroy the player object.
				Destroy (this.gameObject);

				//reset the level
				Reset_Game.Reset ();
			}

		}
	}

	//used to check collision if object has trigger on.
	void OnTriggerEnter2D(Collider2D other)
	{
		
		//the player collides with the laser object
		if (other.gameObject.tag == "laser") 
		{
			reset = true;

			//destroy the player object.
			Destroy (this.gameObject);

			//reset the level
			Reset_Game.Reset ();
		}

		//the player collides with the laser object
		if (other.gameObject.tag == "specialLaser") 
		{
			if (Laser6.canHit)
			{

				reset = true;

				//destroy the player object.
				Destroy (this.gameObject);

				//reset the level
				Reset_Game.Reset ();
			}

		}

	
		//the player collides with door
		if (other.gameObject.tag == "door") 
		{

			reset = true;

			//set level
			level = 2;

			//reset the level
			Reset_Game.Reset ();
		
		}

		//the player collides with door
		if (other.gameObject.tag == "door2") 
		{

			reset = true;

			//set level
			level = 3;

			//reset the level
			Reset_Game.Reset ();

		}

		if (other.gameObject.tag == "lever") 
		{
			lever.GetComponent<Animator> ().enabled = true;
			Destroy (laserDoor);

		}

		if (other.gameObject.tag == "door3")
		{
			reset = true;

			//set level
			level = 4;

			//reset the level
			Reset_Game.Reset ();
		}

		if (other.gameObject.tag == "door4")
		{
			reset = true;

			//set level
			level = 5;

			//reset the level
			Reset_Game.Reset ();
		}

		if (other.gameObject.tag == "door5")
		{
			reset = true;

			//set level
			level = 6;

			//reset the level
			Reset_Game.Reset ();
		}


		if (other.gameObject.tag == "door6")
		{
			reset = true;

			//set level
			level = 7;

			//reset the level
			Reset_Game.Reset ();
		}


		if (other.gameObject.tag == "door7")
		{

			reset = true;

			//set level
			level = 8;

			//reset the level
			Reset_Game.Reset ();
		}

		if (other.gameObject.tag == "door8")
		{
			reset = true;

			//set level
			level = 9;

			//reset the level
			Reset_Game.Reset ();
		}

		if (other.gameObject.tag == "door9")
		{
			reset = true;

			//set level
			level = 10;

			//reset the level
			Reset_Game.Reset ();
		}

		if (other.gameObject.tag == "door10")
		{
			//set level
			level = 11;

			//reset the level
			Reset_Game.Reset ();

			level = 1;
		}
	}
}
