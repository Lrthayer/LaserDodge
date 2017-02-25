using UnityEngine;
using System.Collections;

public class jumpCall : MonoBehaviour {
	bool grounded;
	Animator anim;
	float jump;

	// Use this for initialization
	void Start () {
	}

	public void setTheInput(float input){
		GameObject.FindGameObjectWithTag ("Player").GetComponent<player_movement> ().StartMoving(input);
	}

	public void touchJump()
	{
		//check to see if player is on the ground
		grounded = GameObject.FindGameObjectWithTag("Player").GetComponent<player_movement>().grounded;
		jump = GameObject.FindGameObjectWithTag ("Player").GetComponent<player_movement> ().jump;
		anim = GameObject.FindGameObjectWithTag ("Player").GetComponent<player_movement> ().anim;

		//The player is on the ground
		if(grounded)
		{
			//player jumps
			GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>().velocity = new Vector2(0,jump);
			anim.SetBool ("jumping", true);
		}



	}

	// Update is called once per frame
	void Update () {
	}
}

