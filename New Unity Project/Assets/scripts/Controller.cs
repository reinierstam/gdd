using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
		
	public float speed;
	public float lives;
	private Rigidbody2D rb;
	private bool isgrounded = true;
	private float time_next_jump;
	private float jump_rate  = 0.5f;
	private float score;
	
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float moveVertical = Input.GetAxis ("Vertical");
		
		rb.velocity = new Vector2(speed,rb.velocity.y);
		
		if (moveVertical > 0 && isgrounded){
			if (Time.time > time_next_jump){
				time_next_jump = Time.time + jump_rate;
				rb.velocity = new Vector2(speed,200);
				isgrounded = false;
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Floor"){
			isgrounded = true;
			//Debug.Log("op de grond");
		}
		if(coll.gameObject.tag == "Obstacle"){
			var direction = transform.InverseTransformPoint(coll.transform.position);
			if (-direction.y > coll.transform.lossyScale.y/2) {
				//on top of it, no problem
				isgrounded = true;
			} else {
				lives -= 1;
				Destroy(coll.gameObject);
				//animate player blinking and going trough object is better.
				if (lives == 0){
					gameOver();
				}
			}
		}
    }
	
	void gameOver(){
		//go back to home screen. and save score.
	}
 }

