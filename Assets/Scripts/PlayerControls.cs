using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

	public GameObject shot;
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		

		float hMovement = Input.GetAxisRaw ("Horizontal");
		float firing = Input.GetAxisRaw ("Fire1");

		print ("firing is" + firing);

		transform.Translate (hMovement / 3, 0f, 0f);
		if (firing != 0) {
			FireShot ();
		}




	}

	/// <summary>
	/// Fires the shot.
	/// </summary>
	void FireShot ()
	{
		Instantiate (shot, this.transform.position, this.transform.rotation);
	}
}
