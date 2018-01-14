using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchLookAt : MonoBehaviour {
	protected string scenename;
	protected float MyTime = 0f;
	public float Duration;
	public Transform RadialProgress;
	private bool LookAt;
	public GameObject FadingScriptObject;
	
	public void Start()
	{
		LookAt=false;
		RadialProgress.GetComponent<Image>().fillAmount = MyTime;
	}
	
	public void Update()
	{ 	if(LookAt==true)
			{
			MyTime += Time.deltaTime;
			
			RadialProgress.GetComponent<Image>().fillAmount = MyTime/Duration;
			
			if (MyTime >= Duration)
			{
				changeScene(scenename);
			}
		}
	}
	
	public void detectLookAt(string NeueSzene){
		LookAt = true;
		scenename = NeueSzene;
	}
	
	public void detectNoLookAt(){
		LookAt = false;
		MyTime = 0f;
		RadialProgress.GetComponent<Image>().fillAmount = MyTime;
	}
	
	public IEnumerator changeScene(string scenename)
    {
		float fadeTime = 2f;//FadingScriptObject.GetComponent<FadeIn>().BeginFade(1);
		yield return new WaitForSeconds(fadeTime);
        Application.LoadLevel(scenename);
    }
}
