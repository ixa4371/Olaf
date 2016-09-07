using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * GENERAL DESCRIPTION
 * This class is going to make my snowman explode.
 * It will add a Rigidbody to the game objects described 
 * as member variables.
 * 
 */

public class Explosion : MonoBehaviour 
{
	/*
	 * The following GameObjects are public so I can access them from the Inspector.
	 * Each GameObject is associated with a part of the snowman.
	 */

	public GameObject head;
	public GameObject bottom;
	public GameObject body;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("Explosion script added");
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	/*
	 * When I click on the object that is associated with this script, it
	 * will add a Rigidbody on the specified Gameobjects it contains.
	 */
	void OnMouseDown()
	{
		head.AddComponent<Rigidbody> ();
		body.AddComponent<Rigidbody> ();
		bottom.AddComponent<Rigidbody> ();

		// I need to destroy the collidier of the object in order to prevent
		// it from adding new components when its clicked on
		Destroy (this.GetComponent<Collider>());
	}
}
