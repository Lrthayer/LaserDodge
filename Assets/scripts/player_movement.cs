using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class player_movement : MonoBehaviour {


	public float jump;
	public bool grounded;
	private float movex;
	public float speed;
	public Animator anim;
	bool moveClicked;
	public float theInput = 0;


	public LayerMask whatIsGround;//the layer we consider 'ground' for the player
	public Transform groundCheck; //the game object that will act as the centerpoint for the groundcheck
	public float groundedRadius;


	// Use this for initialization
	void Start () 
	{

		grounded = true;
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () 
	{
		#if UNITY_ANDROID		

		move (theInput);

		//check to see if player is on the ground
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundedRadius, whatIsGround);
		#else

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundedRadius, whatIsGround);
		//The player is on the ground
		if(grounded)
		{
			//player jumps
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
			anim.SetBool ("jumping", false);
		}

		//create sections for different platforms

		//player is pressing the space bar
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			//The player is on the ground
			if(grounded)
			{
				//player jumps
				GetComponent<Rigidbody2D>().velocity = new Vector2(0,jump);
				anim.SetBool ("jumping", true);
			}

		}

		//add horizonal button checking for animator boolean for running animation
		if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			anim.SetBool("running", true);

		}
		else
		{
			
			anim.SetBool("running",false);
		}


		if(movex > 0)
		{
			this.GetComponent<SpriteRenderer>().flipX = false;
		}
		else if(movex < 0)
		{
			this.GetComponent<SpriteRenderer>().flipX = true;
		}
		else
		{

		}

		//gets input from user moving left or right.
		movex = Input.GetAxis ("Horizontal");
		//move(tInput);
		//increase movement
		movex = movex * speed;
		//print (movex);

		//create a movement vector
		Vector2 movements = new Vector2 (movex,0f);

		//move player
		this.transform.Translate (movements);

		#endif

	}//end update

	public void move(float horizontalInput)
	{
		horizontalInput = horizontalInput * speed;
		Vector2 movements = new Vector2 (horizontalInput,0f);
		this.transform.Translate (movements);
		if(movements.x > 0)
		{
			this.GetComponent<SpriteRenderer>().flipX = false;
		}
		else if(movements.x < 0)
		{
			this.GetComponent<SpriteRenderer>().flipX = true;
		}
		else
		{

		}
	}

	public void StartMoving(float horizontalInput)
	{
		theInput = horizontalInput;
		print ("test1");
	}
	public void stopMoving()
	{               
		moveClicked = false;
		print ("test2");
	}
}
