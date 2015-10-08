using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	//Variables Start----------------

	private CharacterController  myController;

	//These control the players movement and the gravity
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	
	//Variables End------------------

	// Use this for initialization
	void Start () 
	{
		myController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (myController.isGrounded) 
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if(Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		myController.Move (moveDirection * Time.deltaTime);
	}
}
