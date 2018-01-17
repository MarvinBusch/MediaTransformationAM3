using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixLightControl : MonoBehaviour {

public float StartTime = 5.0f;
public float Duration = 10.0f;
protected float MyTime = 0f;

public Transform[] Lights;
public float LightIntensity = 1f;

public Transform Türe;
public float LightIntensityTüre = 1f;

public Transform Raum;
public GameObject Hände;
public ParticleSystem MatrixRegen;

private bool Go = false;
private bool end = false;

	// Use this for initialization
	void Start () {
		Go=false;
		end=false;	
		MyTime=0f;
		for(int i=0; i<Lights.Length; i++){
			Lights[i].GetComponent<Light>().intensity = 0f;
		}	
		Türe.GetComponent<Light>().intensity = 0f;
		Hände.SetActive(false);
		Raum.transform.localScale += new Vector3(0, 0, 5);
	}
	
	// Update is called once per frame
	void Update () {
		if(end==false){
			MyTime += Time.deltaTime;
			if(MyTime>StartTime&&Go==false){
				MyTime=0;
				Hände.SetActive(true);
				Go=true;
				Raum.transform.localScale += new Vector3(0, 0, -5);
				//MatrixRegen.Stop();
			}
			if(MyTime>Duration&&Go==true){
				end=true;
			}
			if(Go==true){
				for(int i=0; i<Lights.Length; i++){
					Lights[i].GetComponent<Light>().intensity = LightIntensity * (MyTime/Duration);
				}
				Türe.GetComponent<Light>().intensity = LightIntensityTüre * (MyTime/Duration);
			}
		}
		
	}
}
