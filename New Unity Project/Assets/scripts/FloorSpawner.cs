using UnityEngine;
using System.Collections;

public class FloorSpawner : MonoBehaviour {

	public GameObject floor;
	public GameObject player;
	private float spawn_at = 216f;
	
	// Use this for initialization
	void Start () {
		//Instantiate(floor, new Vector2(12f,-2.5f),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x > spawn_at){
			spawn_at +=216;
			Instantiate(floor, new Vector2(432f + spawn_at,-90f),Quaternion.identity);
		}
	}
}
