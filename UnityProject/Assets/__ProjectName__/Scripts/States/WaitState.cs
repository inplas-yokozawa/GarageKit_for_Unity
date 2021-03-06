﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using GarageKit;

public class WaitState : AsyncStateBase
{
	public Text sceneText;
	public Text timerText;
	public Text messageText;
	
	
	public override void StateStart(object context)
	{
		base.StateStart(context);
		
		sceneText.text = "this is [Wait] scene.";
		timerText.text = "";
		messageText.text = "push [Space] : next scene";
	}
	
	public override void StateUpdate()
	{
		base.StateUpdate();
	}
	
	public override void StateExit()
	{
		base.StateExit();
	}
}