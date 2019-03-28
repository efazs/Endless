using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileManager : MonoBehaviour {
	public GameObject[] tileprefab;

	private Transform playerTransform;// player's transform
	private float spawn = -500.0f;
	private float tileleangth = 500.0f;
	private float safezone = 3000f;
	private int anmtilesonscreen = 7;
	private List<GameObject> activetiles;
	// Use this for initialization
	void Start () {

		activetiles = new List<GameObject>();
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;//transform has been used to typecast GameObject into transform
		//playerTransform = new Transform;
		SpawnTile();
		SpawnTile();
		SpawnTile();




	}

	// Update is called once per frame
	void Update () {
		if (playerTransform.position.x-safezone> spawn - anmtilesonscreen * tileleangth)
		{
			SpawnTile();
			deletetile();
		} 
		
			//SpawnTile();
		
	}
	private void SpawnTile(int PreIndex = -1)
	{
		//transform.Translate(0, 1, 0);
		GameObject go;
		go = Instantiate(tileprefab[0]) as GameObject;
		go.transform.SetParent(transform);
		go.transform.position = new Vector3(1,0,0)* spawn;
		spawn += tileleangth;
		activetiles.Add(go);

		//this.enabled=false;

	}
	private void deletetile()
	{

		Destroy(activetiles[0]);
		activetiles.RemoveAt(0);
	}
	private int randomind()
	{
		if(tileprefab.Length<2)
		{
			return 0;
		}
		return (Random.Range(0, tileprefab.Length));

	}
}
