using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightcontroll : MonoBehaviour {

public float StartTime = 5.0f;
public float Duration = 10.0f;
protected float MyTime = 0f;
public Transform[] Lights;
public float LightIntensity = 1f;
public Transform Flare;
public float FlareIntensity = 1000f;
public float FlareBrightness = 5f;
private bool Go = false;
private bool end = false;

	// Use this for initialization
	void Start () {
		Go=false;
		end=false;
		MyTime=0f;
		Flare.GetComponent<Light>().intensity = 0f;
		Flare.GetComponent<LensFlare>().brightness = 0f;
		for(int i=0; i<Lights.Length; i++){
				Lights[i].GetComponent<Light>().intensity = 0f;
		}
		Flare.GetComponent<LensFlare>().fadeSpeed = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if(end==false){
		MyTime += Time.deltaTime;
		if(MyTime>StartTime&&Go==false){
			MyTime=0;
			Go=true;
			Flare.GetComponent<Light>().intensity = FlareIntensity;
			Flare.GetComponent<LensFlare>().brightness = FlareBrightness;
			Flare.GetComponent<LensFlare>().fadeSpeed = 0;
		}
		if(MyTime>Duration&&Go==true){
			end=true;
		}
		if(Go==true){
			for(int i=0; i<Lights.Length; i++){
				Lights[i].GetComponent<Light>().intensity = LightIntensity * (MyTime/Duration);
			}
		}
		}
	}
}
