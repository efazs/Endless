using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour {
    public Text score;
    float svalue;
    public Text hscore;
	// Use this for initialization
	void Start () {
        score.text = "000";
        hscore.text = "000";
        svalue = 0;
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}

    public void upscore()
    {
        svalue = svalue + Time.deltaTime;
        if (svalue > PlayerPrefs.GetFloat("Last Score"))
        {
            PlayerPrefs.SetFloat("Last Score", svalue);

        }
        hscore.text = ((int)PlayerPrefs.GetFloat("Last Score")).ToString();
        score.text = ((int)svalue).ToString();

    }
}
