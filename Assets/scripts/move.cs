using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float a;
	// Use this for initialization
	void Start () {
        a = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetAxis("Mouse X")>0)
        { transform.Rotate(0,1,0 * .05f,Space.World); }
        else if (Input.GetAxis("Mouse X") < 0)
        { transform.Rotate(0, -1, 0 * .05f, Space.World); }


       /* else if (Input.GetAxis("Mouse Y") > 0)
        { transform.Rotate(new Vector3(0, 0, 1) * .05f, Space.World); }
        else if (Input.GetAxis("Mouse Y") < 0)
        { transform.Rotate(new Vector3(0, 0, -1) * .05f, Space.World); }*/
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow)) { 
            transform.Translate(1*a, 0, 0);
            GetComponent<text>().upscore();
        }
        if (Input.GetKey("down")|| Input.GetKey("s"))
        {
            transform.Translate(-1*a, 0, 0);
        }
       /* if (Input.GetKey(KeyCode.A))
        {
            transform.Translate( 0, 0, 1*a);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate( 0, 0,-1*a);
        }*/

    }
}
