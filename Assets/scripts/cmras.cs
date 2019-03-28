using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmras : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetAxis("Mouse X") > 0)
        //{ transform.Rotate(0, 1, 0 * .05f, Space.World); }
        //else if (Input.GetAxis("Mouse X") < 0)
        //{ transform.Rotate(0, -1, 0 * .05f, Space.World); }


        if (Input.GetAxis("Mouse Y") > 0)
        { transform.Rotate(new Vector3(0, 0, 1) * .5f, Space.World); }
        else if (Input.GetAxis("Mouse Y") < 0)
        { transform.Rotate(new Vector3(0, 0, -1) * .5f, Space.World); }
    }
}
