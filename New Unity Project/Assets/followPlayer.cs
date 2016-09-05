using UnityEngine;
using System.Collections;

public class followPlayer : MonoBehaviour {

	public GameObject player;
	private float speed;
	// Use this for initialization
	void Start () {
		GameObject thePlayer = GameObject.Find("ship");
		Controller controller = thePlayer.GetComponent<Controller>();
		speed = controller.speed;
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 pos = transform.position;
		pos.x = player.transform.position.x;
		pos.x += speed;
		transform.position = pos;
	}
}
