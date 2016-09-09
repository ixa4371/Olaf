using UnityEngine;
using System.Collections;

public class GameCount : MonoBehaviour 
{
	public int count; // number of destroyed snowmen

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("GameCount added");
		count = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnGUI()
	{
		GUI.Box (new Rect (0, 0, 150, 20), "Destroyed Snowmen: " + count.ToString ());
	}
}
