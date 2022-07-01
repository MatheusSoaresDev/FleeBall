using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enemy : MonoBehaviour 
{
	public GameObject Way1;
	public GameObject Way2;
	public GameObject Way3;
	private GameObject TimeStartObject;

	public int way;
	public float timeStart;
	private float impulse;

	private Text tempoText;
	public CircleCollider2D collider;
	public Rigidbody2D physic;

	public bool StartTime;


	public static cronometer instance;

	// Use this for initialization
	void Start () 
	{
		collider.enabled = false;
		impulse = 4.3f;
		timeStart = 4;
		StartTime = true;
		way = Random.Range (1, 4);

		tempoText = GameObject.Find ("TimeStart").GetComponent<Text> ();
		TimeStartObject = GameObject.Find("TimeStart");

		physic = GetComponent<Rigidbody2D> ();

		if (way == 1) 
		{
			transform.position = new Vector2(Way1.transform.position.x, Way1.transform.position.y);
		}
		if (way == 2) 
		{
			transform.position = new Vector2(Way2.transform.position.x, Way2.transform.position.y);
		}
		if (way == 3) 
		{
			transform.position = new Vector2(Way3.transform.position.x, Way3.transform.position.y);
		}
			
	}
	// Update is called once per frame
	void Update ()
	{
		if (timeStart > 0) 
		{
			timeStart -= Time.deltaTime;
		}
		if (StartTime == true) {
			int tempoTexto = (int)timeStart;
			tempoText.text = tempoTexto.ToString ("0");
		}
		if (timeStart < 1) 
		{
			cronometer.StartTime = true;
			physic.AddForce (new Vector2 (impulse, impulse), ForceMode2D.Impulse);
			collider.enabled = true;
			impulse = 0;
			Destroy(TimeStartObject);
		}
	}
}
