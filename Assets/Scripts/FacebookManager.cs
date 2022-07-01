using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Facebook.Unity;
using UnityEngine.UI;

public class FacebookManager : MonoBehaviour 
{
	Gerenciador manager;

	public GameObject DialogLoggedIn;
	public GameObject DialogLoggedOut;
	public GameObject DialogUsername;


	void Start()
	{

	}
	void Update ()
	{
		
	}
		
	/*private void Awake()
	{
		FB.Init (SetInit, OnHideUnity);
	}
	void SetInit()
	{
		if (FB.IsLoggedIn) 
		{
			Debug.Log ("Facebook logged");
		} else {
			Debug.Log ("Facebook not is logged");
		}
		DealWithFBMenus (FB.IsLoggedIn);
	}

	void OnHideUnity(bool isGameShown)
	{
		if (!isGameShown) 
		{
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;	
		}
	}
	public void FBLogIn()
	{
		List<string> permissions = new List<string> ();
		permissions.Add ("public_profile");

		FB.LogInWithReadPermissions (permissions, AuthCallBack);
	}

	void AuthCallBack(IResult result)
	{
		if (result.Error != null) 
		{
			Debug.Log (result.Error);
		} else {
			if (FB.IsLoggedIn) 
			{
				Debug.Log ("FB is logged in");
			} else {
				Debug.Log ("FB not is logged");
			}

			DealWithFBMenus (FB.IsLoggedIn);
		}
	}
	void DealWithFBMenus(bool isLoggedIn)
	{
		if (isLoggedIn) {
			DialogLoggedIn.SetActive (true);
			DialogLoggedOut.SetActive (false);

			FB.API ("/me?fields=first_name", HttpMethod.GET, DisplayUsername);
			//FB.API ("/me/picture?type=square&height=128&width", HttpMethod.GET, DisplayProfilePic);
		} else {
			DialogLoggedIn.SetActive (false);
			DialogLoggedOut.SetActive (true);		
		}
	}
	void DisplayUsername(IResult result)
	{
		Text UserName = DialogUsername.GetComponent<Text> ();

		if (result.Error == null) {
			UserName.text = "" + result.ResultDictionary ["first_name"];
		} else {
			Debug.Log (result.Error);
		}
	}

	void DisplayProfilePic(IGraphResult result)
	{
		if (result.Texture != null) 
		{
			Image ProfilePic = DialogProfilePic.GetComponent<Image> ();

			ProfilePic.sprite = Sprite.Create(result.Texture, new Rect(0,0,128,128), new Vector2());
		}
	}

	/*public void Share()
	{
		FB.ShareLink (
		contentTitle: "Eu bati meu proprio recorde no FleeBall",
		contentURL: new System.Uri("https://play.google.com/store/apps/details?id=com.harmonia.fleeball"),
		contentDescription: "Baixe o app no google play",
		callback:OnShare);
	}

	private void OnShare(IShareResult result)
	{
		if (result.Cancelled || !string.IsNullOrEmpty (result.Error)) 
		{
			Debug.Log ("ShareLonk error: " + result.Error);
		}
	    else if (!string.IsNullOrEmpty (result.PostId))
		{
			Debug.Log (result.PostId);
		}
		else{
			Debug.Log("Share succeed");
		}
	}
	*/
	public void ButtonRegisterFacebook()
	{
		//StartCoroutine (RegisterUserFacebook());
	}
}	
