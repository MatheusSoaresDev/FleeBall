using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBackNext : MonoBehaviour 
{
	private int pag;

	public GameObject Ranking1;
	public GameObject Ranking2;
	public GameObject Ranking3;
	public GameObject Ranking4;
	public GameObject Ranking5;

	public GameObject ButtonBack;
	public GameObject ButtonMenu;

//	public Button buttonNext;
	//public Button buttonBack;

	// Use this for initialization
	void Start ()
	{
		pag = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (pag == 1) 
		{
			pag1 ();
		}
		if (pag == 2) 
		{
			pag2 ();
		}
		if (pag == 3) 
		{
			pag3 ();
		}
		if (pag == 4)
		{
			pag4 ();
		}
		if (pag == 5) 
		{
			pag5 ();
		}
		if (pag == 5) 
		{
			pag = 5;
		}
		if (pag == 1) {
			ButtonBack.gameObject.active = false;
			ButtonMenu.gameObject.active = true;
		} else {
			ButtonBack.gameObject.active = true;
			ButtonMenu.gameObject.active = false;
		}

	}
	public void ClickNext ()
	{
		pag += 1;
	}
	public void ClickBack ()
	{
		pag -= 1;
	}
	public void ClickButtonMenu ()
	{
		Application.LoadLevel ("menu");
	}


	public void pag1 ()
	{
		Ranking1.gameObject.active = true;
		Ranking2.gameObject.active = false;
		Ranking3.gameObject.active = false;
		Ranking4.gameObject.active = false;
		Ranking5.gameObject.active = false;
	}
	public void pag2 ()
	{
		Ranking1.gameObject.active = false;
		Ranking2.gameObject.active = true;
		Ranking3.gameObject.active = false;
		Ranking4.gameObject.active = false;
		Ranking5.gameObject.active = false;
	}
	public void pag3 ()
	{
		Ranking1.gameObject.active = false;
		Ranking2.gameObject.active = false;
		Ranking3.gameObject.active = true;
		Ranking4.gameObject.active = false;
		Ranking5.gameObject.active = false;
	}
	public void pag4 ()
	{
		Ranking1.gameObject.active = false;
		Ranking2.gameObject.active = false;
		Ranking3.gameObject.active = false;
		Ranking4.gameObject.active = true;
		Ranking5.gameObject.active = false;
	}
	public void pag5 ()
	{
		Ranking1.gameObject.active = false;
		Ranking2.gameObject.active = false;
		Ranking3.gameObject.active = false;
		Ranking4.gameObject.active = false;
		Ranking5.gameObject.active = true;
	}
}
