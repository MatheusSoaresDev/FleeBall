using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterManager : MonoBehaviour 
{

	string TWITTER_ADRESS = "https://twitter.com/intent/tweet";

	string TWEET_LANGUAGE = "en";

	string textToDisplay = "Eu superei minha pontuação no flee ball";

	public int score;

	// Use this for initialization
	public void ShareTwitter () 
	{
		Application.OpenURL (TWITTER_ADRESS + "?text" + WWW.EscapeURL (textToDisplay) + score + "&amp;lang=" + WWW.EscapeURL (TWEET_LANGUAGE));	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
