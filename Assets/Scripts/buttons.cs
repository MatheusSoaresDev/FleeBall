using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttons : MonoBehaviour 
{
	public static cronometer instance;

	private string SceneGame;
	private string SceneMenu;

	// Use this for initialization
	void Start () 
	{
		SceneGame = "level_01";
		SceneMenu = "menu";
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void tryagain ()
	{
		Application.LoadLevel (SceneGame);
		cronometer.time = 0;
		cronometer.TempoInteiro = 0;
	}
	public void menu ()
	{
		Application.LoadLevel (SceneMenu);
		cronometer.time = 0;
		cronometer.TempoInteiro = 0;
	}
	public void GameOverRestart()
	{
		Application.LoadLevel ("level_01");
	}


}
