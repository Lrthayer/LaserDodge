using UnityEngine;
using System.Collections;

public class DroidLaserMovement : MonoBehaviour {

	public int deathTimer;
	private int timer;
	private GameObject followObject;
	public int droidLaser;

	private Vector2 newPosition;
	// Use this for initialization
	void Start () 
	{
		followObject = GameObject.Find ("waypoint");
		newPosition.x = followObject.transform.position.x;
		newPosition.y = followObject.transform.position.y;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += 1;

		if (timer > deathTimer) 
		{
			Destroy (this.gameObject);
		}

		this.transform.position = Vector2.MoveTowards (transform.position, newPosition, droidLaser * Time.deltaTime);


	}


}
