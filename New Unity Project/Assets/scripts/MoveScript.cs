using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	public Vector2 Speed = new Vector2(0.0f, 0.0f);
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		if(rb!= null) {
			rb.velocity = new Vector2(Speed.x, Speed.y);
		}
	}

	void Update(){
		// voorbeeld zonder time factor
		if(rb == null) {
			transform.Translate(Speed.x, Speed.y, 0);
		}
	}

}
