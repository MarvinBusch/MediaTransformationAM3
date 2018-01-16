using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {

	public GameObject Flare;
	
	// Update is called once per frame
	void Update () {
		if(Flare.GetComponent<LensFlare>().fadeSpeed == 0)
		{
			GetComponent<AudioSource>().Play();
		}
	}
}
