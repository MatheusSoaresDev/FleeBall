using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ButtonsGame : MonoBehaviour 
{
	public int sceneRandom;
	public static Login instance;
	public GameObject ShareWindow;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		
	}

	public void startGame()
	{
		Application.LoadLevel ("menuSelect");
	}

	public void basket()
	{
		Application.LoadLevel ("Basket");
	}
	public void Futsal()
	{
		Application.LoadLevel ("Futsal");
	}
	public void PingPong()
	{
		Application.LoadLevel ("PingPong");
	}
	public void soccer()
	{
		Application.LoadLevel ("soccer");
	}
	public void Tennis()
	{
		Application.LoadLevel ("Tenis");
	}
	public void Voley()
	{
		Application.LoadLevel ("Voley");
	}
	public void replay()
	{
		Application.LoadLevel ("menuSelect");
	}
	public void ranking()
	{
		Application.LoadLevel ("ranking");
	}
	public void menu()
	{
		Application.LoadLevel ("menu");
	}
	public void profile()
	{
		Application.LoadLevel ("profile");	
	}
	public void exit()
	{
		Application.LoadLevel ("login");
		PlayerPrefs.SetString ("nickNamePF", "");
		PlayerPrefs.SetString ("NickNameFacebook", "");
	}

	public void fechaRedesSociais()
	{
		GameObject.Destroy (ShareWindow);
	}

	public void random()
	{
		sceneRandom = Random.Range (1, 6);

		if (sceneRandom == 1) 
		{
			Application.LoadLevel ("Basket");
		}
		if (sceneRandom == 2) 
		{
			Application.LoadLevel ("Futsal");
		}
		if (sceneRandom == 3) 
		{
			Application.LoadLevel ("PingPong");
		}
		if (sceneRandom == 4) 
		{
			Application.LoadLevel ("soccer");
		}
		if (sceneRandom == 5) 
		{
			Application.LoadLevel ("Tenis");
		}
		if (sceneRandom == 6) 
		{
			Application.LoadLevel ("Voley");
		}
	}

}