// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;


public class Timer
{
	private float interval;
	private float timeSave;
	private bool isSet;

	public Timer (float interval)
	{
		this.interval = interval;
		isSet = false;
	}

	public void set()
	{
		isSet = true;
		timeSave = Time.time;
	}

	public bool check()
	{
		if (!isSet) {
			return false;
		} 
		else 
		{
			//isSet = false;
			return ( (Time.time - timeSave) >= interval);
		}	
	}
}


