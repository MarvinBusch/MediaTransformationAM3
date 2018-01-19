﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeDrehen : MonoBehaviour {

	public Transform Namen;
	public float namenSpeed = 4f;
	
	public Transform Oben;
	public float obenSpeed = 2f;
	
	public Transform Unten;
	public float untenSpeed = -2f;

	
	// Update is called once per frame
	void Update () {
		Namen.transform.Rotate(0, 0, namenSpeed * Time.deltaTime);
		Unten.transform.Rotate(0, 0, untenSpeed * Time.deltaTime);
		Oben.transform.Rotate(0, 0, obenSpeed * Time.deltaTime);
	}
}
