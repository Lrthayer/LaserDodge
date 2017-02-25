using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		#if UNITY_ANDROID	

		if (Input.anyKey)	
		{
			Application.LoadLevel ("scenes/level1");
		}

		#else
			if (Input.anyKey)	
			{
				Application.LoadLevel ("scenes/level1");
			}


		#endif
	}
}
