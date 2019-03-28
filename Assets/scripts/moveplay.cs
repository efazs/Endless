using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, 1 * .7f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, -1 * .7f);
        }
        /*if(Input.GetMouseButton(0))
        {
            if ( Input.mousePosition.x < Screen.width / 2)
            {
                transform.Translate(0, 0, 1 * .07f);
            }
            if ( Input.mousePosition.x > Screen.width / 2)
            {
                transform.Translate(0, 0, -1 * .07f);
            }


        }*/
    }
}
