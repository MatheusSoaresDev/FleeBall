using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Gerenciador : MonoBehaviour 
{
	public GameObject canvasLogin;

	// Use this for initialization
	void Start () 
	{
		canvasLogin.SetActive (true);
	}

	public void registrar()
	{
		canvasLogin.SetActive (false);
	}
	public void retornarLogin()
	{
		canvasLogin.SetActive (true);
	}
	public void logged()
	{
		Application.LoadLevel ("menu");
	}

}