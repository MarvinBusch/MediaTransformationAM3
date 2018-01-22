using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControllFluss : MonoBehaviour {

	public GameObject Boot;
	public GameObject Schaedel;

	// Use this for initialization
	void Start () {
		if(SaveVariable.Utopie==false){
			Boot.GetComponent<Animator>().SetBool("Dystopie", true);
			Schaedel.GetComponent<Animator>().SetBool("MundOeffnen", true);
		}	
		else{
			Boot.GetComponent<Animator>().SetBool("Utopie", true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Boot.GetComponent<Animator>().GetBool("Dystopie")==true)
		{
			Debug.Log(Boot.GetComponent<Animator>().GetBool("Dystopie"));
		}
	}
}
