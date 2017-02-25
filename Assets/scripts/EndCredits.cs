using UnityEngine;
using System.Collections;

public class EndCredits : MonoBehaviour {

	public static int credits = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey)
		{
			if (credits == 1) {
				Application.LoadLevel ("scenes/EndCredits1");
				credits++;
			} else if (credits == 2) {
				Application.LoadLevel ("scenes/EndCredits2");
				credits++;
			} else if (credits == 3) {
				credits++;
				Application.LoadLevel ("scenes/EndCredits3");
			} else {
				Application.LoadLevel ("scenes/Title");
				credits = 1;
			}
		}

	}
}
