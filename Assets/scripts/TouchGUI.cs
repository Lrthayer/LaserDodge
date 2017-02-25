using UnityEngine;
using System.Collections;

public class TouchGUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	#if UNITY_ANDROID

	#else
		this.transform.Translate(new Vector2(10000,10101010));

	#endif
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
