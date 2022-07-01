using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rank : MonoBehaviour 
{

	public Text[] rankText;
	private string[] rankSplit;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (pegaRank ());
	}
	
	// Update is called once per frame

	IEnumerator pegaRank()
	{
		WWWForm form = new WWWForm ();

		form.AddField ("action", "pegaRank");

		WWW retorno = new WWW ("http://localhost/FleeBall/UnityMySQL.php", form);

		yield return retorno;

		if (retorno.error == null) {
			string r = retorno.text;
			//Debug.Log (r);
			rankSplit = r.Split ('|');

			for (int i = 0; i < 50; i++) {
				rankText[i].text = rankSplit [i];
			}
		} else {
			Debug.Log ("error " + retorno.error);
		}
	}

}
