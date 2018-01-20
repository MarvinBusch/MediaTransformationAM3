using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitchAnimationEnd : MonoBehaviour {
	
	public string scenename = "Fluss";
	protected float MyTime = 0f;
	protected float AnimationLength = 60f;
	
	protected Animator m_Animator;
	AnimatorClipInfo[] m_CurrentClipInfo;
	
	protected bool ResetMytime = false;
	
	public float FadeDuration = 3f;
	
	public GameObject AnimationObject;

	public GameObject FadingScriptObject;

	public void Start(){
		m_Animator = AnimationObject.GetComponent<Animator>();
		m_CurrentClipInfo = this.m_Animator.GetCurrentAnimatorClipInfo(0);
		AnimationLength = m_CurrentClipInfo[0].clip.length;

		ResetMytime=false;
	}
	
	
	public void Update()
	{
			MyTime += Time.deltaTime;
			if (MyTime > AnimationLength - FadeDuration)
			{
				if (ResetMytime==false){
					ResetMytime=true;
					FadingScriptObject.GetComponent<FadeIn>().BeginFade(1/(FadeDuration)*2.5f);
					MyTime=0;
				}
			}
			if (ResetMytime==true){
				if (MyTime>FadeDuration)
				{
					changeScene(scenename);
				}
			}
	}
	
	public void changeScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
