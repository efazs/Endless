using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nxtscene : MonoBehaviour {
    public Button nxt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        nxt.onClick.AddListener(nxtscn);
    }

    public void nxtscn()
    {

        SceneManager.LoadScene("asd");

    }
}
