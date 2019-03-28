using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pshooter : MonoBehaviour {
	AudioSource ads;
	//public Texture2D crosshairImage;
	//public AudioClip adc;
	public GameObject prefab;
	public Animator anim;
	public RuntimeAnimatorController animc;
	//private Transform lookat;
	private List<GameObject> activepro;
	private int round;
	// Use this for initialization
	void Start () {
		activepro = new List<GameObject>();
		ads = GetComponent <AudioSource> ();
		round = 0;
		anim = GetComponent<Animator> ();
		anim.runtimeAnimatorController = animc;
		//ads.clip = adc;
		//lookat = GameObject.FindGameObjectWithTag("play").transform;
	}

	// Update is called once per frame
	/*void OnGUI() //for coded crossheir
	{
		float xMin = (Screen.width / 2) - (crosshairImage.width / 2);
		float yMin = (Screen.height / 2) - (crosshairImage.height / 2);
		GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
	}*/
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			ads.Play();
			round++;
			if(round!=6)
			{
				
				anim.SetInteger("ianim",1);

			}
			else if(round==6)
			{
				round = 0;
				anim.SetInteger("ianim",3);

			}
			GameObject shooter = Instantiate(prefab) as GameObject;

			//shooter.transform.position = transform.position + Camera.main.transform.right* 2;
			shooter.transform.position =this.transform.position + Camera.main.transform.up *2.8f;
			shooter.transform.rotation = Camera.main.transform.rotation;
			//shooter.transform.Rotate(0, 0, 90, Space.World);
			//shooter.transform.Rotate(0, 0, 0 , Space.World);
			Rigidbody rb = shooter.GetComponent < Rigidbody>();
			rb.velocity = Camera.main.transform.forward*(1000);
			activepro.Add(shooter);
			//transform.Rotate(1, 0, 0 * .05f, Space.World);
			//rb.GetComponent<TrailRenderer>().endColor=000000;
			if(activepro.Count>100)
			{
				Destroy(activepro[0]);
				activepro.RemoveAt(0);

			}
			StartCoroutine(WaitSHoot());

		}
		if(Input.GetKey("r"))
		{
			anim.SetInteger("ianim", 3);
			StartCoroutine(WaitSHoot());
		}

	   

		for (int i = 0; i < 1000000; i++)
		{

		}
		//for (int i = 0; i < 100000; i++) ;
		//anim.SetInteger("ianim", 0);
	}
	IEnumerator WaitSHoot()
	{
		yield return new WaitForSeconds(1.3f);
		anim.SetInteger("ianim", 0);
	}
}

