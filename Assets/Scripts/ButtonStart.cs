using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonStart : MonoBehaviour 
{
	public string scene;
	public Button buttons;

	// Use this for initialization
	void Start () 
	{
		Button btn = buttons.GetComponent<Button> ();
		buttons.onClick.AddListener (TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void TaskOnClick ()
	{
		Application.LoadLevel (scene);
	}
}
