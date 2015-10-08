using UnityEngine;
using System.Collections;

/// <summary>
/// This script is attached to the player and it caises the camera to continously follow the CameraHead. 
/// </summary>

public class CameraScript : MonoBehaviour {

	//Variables Start--------------------------------

	private Camera myCamera;

	private Transform cameraHeadTransform;

	//Variables End----------------------------------

	// Use this for initialization
	void Start () 
	{
		myCamera = Camera.main;

		cameraHeadTransform = transform.FindChild("CameraHead");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Make the camera follow the player's cameraHeadTransform.

		myCamera.transform.position = cameraHeadTransform.position;

		myCamera.transform.rotation = cameraHeadTransform.rotation;
	}
	
}
