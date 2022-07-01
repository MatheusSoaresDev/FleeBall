using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cronometer : MonoBehaviour 
{
	public static float time;
	public static int TempoInteiro;
	public static float record;
	public static float PontFinal;
	public static bool StartTime;

	public string scene;

	public Text UIText;

	// Use this for initialization
	void Start () 
	{
		StartTime = false;
	}
		
	// Update is called once per frame
	void Update () 
	{
		if (StartTime == true) 
		{
			time += Time.deltaTime;
		}
		if(time - TempoInteiro > 1)
		{
			TempoInteiro +=1;
		}

		UIText.text = time.ToString("f0");
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		PlayerPrefs.SetFloat ("Score", time);
		if (time > record) 
		{
			record = time;

		}
		Application.LoadLevel ("gameover");
	}
}