using UnityEngine;
using System.Collections;

public class ShootBlaster : MonoBehaviour 
{
	//Variables Start-----------------

	//This is terms for Launch position of blaster, and the blaster itself
	public Rigidbody blasterPrefab;
	public Transform ProjectileLaunch;

	//This controls the blaster fire rate
	public float nextFire=0;
	public float fireRate=0.2f;

	//Explosion Particles
	public GameObject blasterExplosion;

	//Variables End-------------------

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		//What happens when you fire the blaster
		if (Input.GetButton ("Fire Weapon")&& Time.time > nextFire) 
		{
			//This allows the blaster to be fired as a rigid body, and adds force to manipulate speed
			Rigidbody blasterInstance;
			blasterInstance = Instantiate(blasterPrefab, ProjectileLaunch.position, ProjectileLaunch.rotation) as Rigidbody;
			blasterInstance.AddForce(ProjectileLaunch.up * 500);

			//This is the control for how fast it can shoot another round
			nextFire = Time.time + fireRate;
		}
	}
}


