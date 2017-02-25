using UnityEngine;
using System.Collections;

public class Destroy_Laser : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DestroyLaser()
	{
		//destroy the laser
		Destroy (this.transform.parent.gameObject);
	}
}
