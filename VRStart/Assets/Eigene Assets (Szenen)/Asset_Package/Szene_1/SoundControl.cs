using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour {

	protected float MyTime = 0f;
	public GameObject Flare;
	protected float brightness;
	protected bool AudioEnded=false;
	
	void Start() {
		brightness = Flare.GetComponent<LensFlare>().brightness;
		AudioEnded = false;
	}
	
	// Update is called once per frame
	void Update () {
		MyTime += Time.deltaTime;
		if(Flare.GetComponent<LensFlare>().brightness != brightness)
		{
			GetComponent<AudioSource>().Play();
			MyTime=0f;
		}
		if(MyTime>GetComponent<AudioSource>().clip.length)
		{	
			Application.LoadLevel("Matrix");
		}
	}
}
