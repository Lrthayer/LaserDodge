using UnityEngine;
using System.Collections;

public class Droid : MonoBehaviour {

	public GameObject followObject;
	public float droidSpeed;
	public float angle = 0;

	// Use this for initialization
	void Start () 
	{
		

	}
	
	// Update is called once per frame
	void Update () 
	{

		if(followObject != null)
		{
			if (Vector2.Distance (transform.position, followObject.transform.position) < 1.5f) {

			} else 
			{
				Vector3 dir = followObject.transform.position - this.transform.position;
				float angle = Mathf.Atan2 (dir.y, dir.x) * Mathf.Rad2Deg;
				transform.rotation = Quaternion.AngleAxis (angle - 90, Vector3.forward);

				this.transform.position = Vector2.MoveTowards (transform.position, followObject.transform.position, droidSpeed * Time.deltaTime);
			}

		}



	
	}
}
