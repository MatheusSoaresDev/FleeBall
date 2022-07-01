using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stats : MonoBehaviour 
{
	public Text[] rankText;
	private string[] rankSplit;

	public static Login instance;
	public Text BestScore;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (BestScoreUsuario ());
	}

	// Update is called once per frame
	IEnumerator BestScoreUsuario()
	{
		WWWForm form = new WWWForm ();

		form.AddField ("action", "PegaStats");
		form.AddField ("nickName", PlayerPrefs.GetString("nickNamePF"));

		WWW retorno = new WWW ("http://localhost/FleeBall/UnityMySQL.php", form);

		yield return retorno;

		if (retorno.error == null) {
			string r = retorno.text;
			Debug.Log (r);
			BestScore.text = r;
		} else {
			Debug.Log ("error " + retorno.error);
		}
	}

}
