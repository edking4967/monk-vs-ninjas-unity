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
	private bool running;

	public Timer (float interval)
	{
		this.interval = interval;
		running = false;
	}

	public void set()
	{
		running = true;
		timeSave = Time.time;
	}

	public bool isRunning()
	{
		return running;
	}

	public bool check()
	{
		if (!running || (Time.time - timeSave) <= interval)
		{
			return false;
		} 
		else 
		{
			running = false;
			return true;
		}	
	}
}


