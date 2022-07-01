using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPanel : MonoBehaviour 
{
	public float time;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		time += Time.deltaTime;
		if (time > 3) 
		{
			gameObject.SetActive (false);
			time = 0;
		}
	}
}
