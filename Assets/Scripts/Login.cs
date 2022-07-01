using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine;

public class Login : MonoBehaviour
{
	Gerenciador manager;

	//public Text TextoRetorno;
	public string nickName;
	public float time;
	public Text ConnectError;

	public static FacebookManager instance;

	// Use this for initialization
	void Start ()
	{		
		manager = this.gameObject.GetComponent<Gerenciador> ();
	}
	void Update ()
	{
		time += 1 * Time.deltaTime;	

		if (time > 5) {
			if (PlayerPrefs.GetString ("nickNamePF") == "") {
				Application.LoadLevel ("login");
			} else {
				nickName = PlayerPrefs.GetString ("nickNamePF");
				StartCoroutine (LoginConventional ());
			}
		}
	}

	IEnumerator LoginConventional()
	{
		WWWForm form = new WWWForm ();

		form.AddField ("action" , "login");
		form.AddField ("nickName" , nickName);

		WWW retorno = new WWW ("http://localhost/FleeBall/UnityMySQL.php", form);

		yield return retorno;

		if (retorno.error == null) {
			string r = retorno.text;
			Debug.Log (r);

			Application.LoadLevel ("menu");
		}else{
			Debug.Log("error "+retorno.error);
			ConnectError.text = "Connection error";
		}
	}

	/*public void EncryptMd5(string input)
	{
		System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create ();
		byte[] data = md5.ComputeHash (System.Text.Encoding.Default.GetBytes (input));
		System.Text.StringBuilder sbString = new System.Text.StringBuilder ();
		for (int i = 0; i < data.Length; i++)
			sbString.Append (data [i].ToString ("x2"));
		senhaMD5 = sbString.ToString ();
		StartCoroutine (LoginUsuario(senhaMD5));
	}*/
}