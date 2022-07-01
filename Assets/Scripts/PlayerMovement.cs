using UnityEngine;
using System.Collections;

/// <summary>
/// Player movement, follow mouse/finger
/// </summary>
public class PlayerMovement : MonoBehaviour 
{
	public float moveSpeed;
	Vector3 mousePosition;
	private bool isDown;
	public float offset;

	public float limiteXUp;
	public float limiteXDown;

	public float limiteYUp;
	public float limiteYDown;

	void Start () 
	{
		isDown = false;
	}

	void Update () 
	{
		if(isDown)
		{
			transform.position = Vector2.Lerp(transform.position, Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y + offset)), moveSpeed);
		}
		if(transform.position.x > limiteXUp) 
		{
			transform.position = new Vector3(limiteXUp, transform.position.y, 0);
		}
		if(transform.position.x < limiteXDown) 
		{
			transform.position = new Vector3(limiteXDown, transform.position.y, 0);
		}
		if(transform.position.y > limiteYUp)
		{
			transform.position = new Vector3(transform.position.x, limiteYUp, 0);
		}
		if(transform.position.y < limiteYDown)
		{
			transform.position = new Vector3(transform.position.x, limiteYDown, 0);
		}
	}

	void OnMouseDown ()
	{
		isDown = true;
	}

	void OnMouseUp ()
	{
		isDown = false;
	}
}













