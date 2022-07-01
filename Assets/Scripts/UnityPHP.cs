using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UnityPHP : MonoBehaviour 
{
	public InputField inputNickName;
	public InputField inputPassword;

	// Use this for initialization
	void Start () 
	{

	}

	public void enviarDados ()
	{
		StartCoroutine (testeUnityPHP());
	}

	IEnumerator testeUnityPHP()
	{
		WWWForm form = new WWWForm ();

		form.AddField ("action" , "teste_unity_php");
		form.AddField ("nickName" , inputNickName.text);
		form.AddField ("senha" , inputPassword.text);

		WWW retorno = new WWW ("http://fleeballgame.esy.es/FleeBall/UnityMySQL.php", form);

		yield return retorno;

		if (retorno.error == null) {
			string r = retorno.text;
			Debug.Log (r);
		}else{
			Debug.Log("error "+retorno.error);
		}
	}
}
