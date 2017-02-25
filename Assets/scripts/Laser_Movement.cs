using UnityEngine;
using System.Collections;

public class Laser_Movement : MonoBehaviour {

	public Vector2 move;
	private GameObject spawn;
	private GameObject spawn2;
	private GameObject spawn3;
	private GameObject spawn4;

	// Use this for initialization
	void Start () 
	{
		move.x = 0;
		move.y = .3f;
		spawn = GameObject.FindGameObjectWithTag ("Respawn");
	
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.Translate (move);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "box1") 
		{
			this.transform.rotation = spawn.transform.rotation;
			this.transform.position = spawn.transform.position;
		}

		if (other.gameObject.tag == "box2") 
		{
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "box22") 
		{
			spawn2 = GameObject.FindGameObjectWithTag ("Respawn2");
			this.transform.rotation = spawn2.transform.rotation;
			this.transform.position = spawn2.transform.position;
		}

		if (other.gameObject.tag == "box3") 
		{
			spawn3 = GameObject.FindGameObjectWithTag ("Respawn3");
			this.transform.rotation = spawn3.transform.rotation;
			this.transform.position = spawn3.transform.position;
		}

		if (other.gameObject.tag == "box4")
		{
			spawn4 = GameObject.FindGameObjectWithTag ("Respawn4");
			this.transform.rotation = spawn4.transform.rotation;
			this.transform.position = spawn4.transform.position;
		}

		if (other.gameObject.tag == "Finish") 
		{
			Destroy (this.gameObject);
		}
	}


}
