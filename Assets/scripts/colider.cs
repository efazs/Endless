using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colider : MonoBehaviour {


	Collider ob;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}
	void OnCollisionEnter(Collision coll)
	{
	   // Collision coll;
	   if(coll.gameObject.tag=="death")
		{
			Destroy(GameObject.FindGameObjectWithTag("bullet"));
			Destroy(coll.gameObject);
			
		}
	   
	}
}
