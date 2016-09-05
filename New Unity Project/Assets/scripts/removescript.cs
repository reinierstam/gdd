using UnityEngine;
using System.Collections;

public class removescript : MonoBehaviour {
	
	public GameObject player;
	
	void Update(){
		if (GameObject.FindWithTag("Player").transform.position.x - transform.position.x > 180){
			Destroy(gameObject);
		}
	}
}
