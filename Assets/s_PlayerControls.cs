using UnityEngine;
using System.Collections;

public class s_PlayerControls : MonoBehaviour 
{

	public float playerSpeed;
	public Vector2 jumpForce = new Vector3(0, 340);
	public Vector2 jumpForceDown = new Vector3(0, -350);
	
	#region Start/Update
	
	void Start ()
	{
		//Original speed of player
		playerSpeed = 4;
	}
	
	void Update () 
	{
		//Left to right
		float amtToMove = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
		transform.Translate (Vector3.right * amtToMove);
		
		if(Input.GetKeyDown ("space"))
		{
			rigidbody.velocity = Vector2.zero;
			rigidbody.AddForce(jumpForce);
		}
		
		if(Input.GetKeyUp ("space"))
		{
		rigidbody.velocity = Vector2.zero;
		rigidbody.AddForce(jumpForceDown);
		}
	}

	#endregion
}
