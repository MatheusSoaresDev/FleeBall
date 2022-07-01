using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
	public static cronometer instance;
	public float score;
	public Text UIText;
	
	// Use this for initialization
	void Start () 
	{	
		
	}	
	
	// Update is called once per frame
	void Update () 
	{
		score = PlayerPrefs.GetFloat ("Score");
		UIText.text = score.ToString("0");
	}
}
