using UnityEngine;
using System.Collections;

public class create_laser : MonoBehaviour {

	public GameObject laser;
	public Transform objectSpawn;
	public int timer;
	public int createLaserOffset;

	// Use this for initialization
	void Start () 
	{
		//set variables at start time.
		timer = 0;
		Instantiate (laser, objectSpawn.position, objectSpawn.rotation);
	}
	
	// Update is called once per frame
	void Update ()
	{
		//increment the timer by one for each frame.
		timer += 1;

		//enough time has passed to spawn laser
		if (timer >= createLaserOffset) 
		{
			//create copy with laser prefab
			Instantiate (laser, objectSpawn.position, objectSpawn.rotation);

			//reset timer
			timer = 0;
		}
	}

}
